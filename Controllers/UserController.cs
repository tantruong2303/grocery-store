using System;

using Microsoft.AspNetCore.Mvc;
using Backend.Controllers.DTO;
using Backend.Utils.Common;
using Backend.Services.Interface;
using Microsoft.AspNetCore.Http;
using System.Web;
using Backend.Pipe;

namespace Backend.Controllers
{
    [Route("user")]
    [ServiceFilter(typeof(AuthGuard))]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("")]
        public IActionResult GetUser()
        {

            return View(Routers.User.Page);
        }

        [HttpGet("password")]
        public IActionResult UpdatePassword()
        {
            return View(Routers.UpdatePassword.Page);
        }

        [HttpPost("password")]
        public IActionResult handleUpdatePassword(string oldPassword, string newPassword, string confirmNewPassword)
        {
            var input = new UpdatePasswordDTO()
            {
                oldPassword = oldPassword,
                newPassword = newPassword,
                confirmNewPassword = confirmNewPassword
            };

            var isUpdate = this.userService.updatePasswordHandler(input, this.ViewData);
            if (!isUpdate)
            {
                return View(Routers.UpdatePassword.Page);
            }

            this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1),
                SameSite = SameSiteMode.None,
                Secure = true

            });
            return Redirect(Routers.Login.Link);
        }

        [HttpGet("info")]
        public IActionResult UpdateUserInfo()
        {
            return View(Routers.UpdateUserInfo.Page);
        }

        [HttpPost("info")]
        public IActionResult handleUpdateUserInfo(string name, string email, string phone, string address)
        {
            var input = new UpdateUserInfoDTO()
            {
                name = name,
                email = email,
                phone = phone,
                address = address
            };

            var isUpdate = this.userService.updateUserInfoHandler(input, this.ViewData);

            if (!isUpdate)
            {
                return View(Routers.UpdateUserInfo.Page);
            }

            return Redirect(Routers.Home.Link);
        }
    }
}