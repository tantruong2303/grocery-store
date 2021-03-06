using System;
using Microsoft.AspNetCore.Mvc;
using Backend.Controllers.DTO;
using Backend.Utils.Common;
using Backend.Services.Interface;
using Microsoft.AspNetCore.Http;

namespace Backend.Controllers
{

    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly IAuthService AuthService;

        public AuthController(IAuthService authService)
        {
            this.AuthService = authService;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {

            return View(Routers.Login.Page);
        }


        [HttpPost("login")]
        public IActionResult HandleLogin(string username, string password)
        {
            var input = new LoginDTO() { Username = username, Password = password };
            var token = this.AuthService.LoginHandler(input, this.ViewData);

            if (token == null)
            {
                return View(Routers.Login.Page);
            }
            this.HttpContext.Response.Cookies.Append("auth-token", token, new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
                SameSite = SameSiteMode.None,
                Secure = true

            });

            return Redirect(Routers.Home.Link + "?message=login success");
        }


        [HttpGet("register")]
        public IActionResult Register()
        {
            return View(Routers.Register.Page);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {

            this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1),
                SameSite = SameSiteMode.None,
                Secure = true

            });

            return Redirect(Routers.Login.Link + "?message=logout success");
        }


        [HttpPost("register")]
        public IActionResult HandleRegister(string name, string username, string password, string confirmPassword, string email, string phone, string address)
        {
            var input = new RegisterDTO()
            {
                Name = name,
                Username = username,
                Password = password,
                ConfirmPassword = confirmPassword,
                Email = email,
                Phone = phone,
                Address = address,
            };

            var isValid = this.AuthService.RegisterHandler(input, this.ViewData);

            if (!isValid)
            {
                return View(Routers.Register.Page);
            }

            return Redirect(Routers.Login.Link + "?message=register success");
        }

    }
}