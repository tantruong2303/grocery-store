using Microsoft.AspNetCore.Mvc;
using Backend.Services.Interface;
using Backend.Utils.Common;
using Backend.Controllers.DTO;
using Backend.Pipe;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("category")]
    [RoleGuardAttribute(new UserRole[] { UserRole.MANGER })]
    [ServiceFilter(typeof(AuthGuard))]
    public class CategoryController : Controller
    {
        private readonly ICategoryService CategoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.CategoryService = categoryService;
        }


        [HttpGet("")]
        public IActionResult Category()
        {
            var categories = this.CategoryService.GetCategories();

            this.ViewData["categories"] = categories;
            return View(Routers.Category.Page);
        }


        [HttpGet("create")]
        public IActionResult CreateCategory()
        {
            return View(Routers.CreateCategory.Page);
        }


        [HttpPost("create")]
        public IActionResult HandleCreateCategory(string name, string description, int status)
        {
            var input = new CreateCategoryDTO()
            {
                Name = name,
                Description = description,
                Status = status
            };
            var isValid = this.CategoryService.CreateCategoryHandler(input, this.ViewData);
            if (!isValid)
            {
                return View(Routers.CreateCategory.Page);
            }

            return Redirect(Routers.Category.Link + "?message=create category success");
        }



        [HttpGet("update")]
        public IActionResult UpdateCategory(string categoryId)
        {
            var category = this.CategoryService.GetCategory(categoryId);
            this.ViewData["category"] = category;
            return View(Routers.UpdateCategory.Page);
        }


        [HttpPost("update")]
        public IActionResult handleUpdateCategory(string categoryId, string name, string description, CategoryStatus status)
        {
            var input = new UpdateCategoryDTO()
            {
                CategoryId = categoryId,
                Name = name,
                Description = description,
                Status = status
            };
            var isValid = this.CategoryService.UpdateCategoryHandler(input, this.ViewData);
            if (!isValid)
            {
                return this.UpdateCategory(categoryId);
            }

            return Redirect(Routers.Category.Link + "?message=update category success");
        }
    }
}