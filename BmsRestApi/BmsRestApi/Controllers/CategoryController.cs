using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BmsRestApi.Messages.Request.Category;
using BmsRestApi.Messages.Response.Category;
using BmsRestApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BmsRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(template:"{id}")] // get category by id
        public ActionResult <GetCategoryResponse> GetCategory(long id)
        {
            var getCategoryRequest = new GetCategoryRequest
            {
                Id = id
            };
            var getCategoryResponse = _categoryService.GetCategory(getCategoryRequest);
            return getCategoryResponse;
        }

        [HttpGet()] // get all categories
        public ActionResult<FetchCategoryResponse> GetCategories()
        {
            var fetchCategoriesRequest = new FetchCategoriesRequest { };
            var fetchCategoriesResponse = _categoryService.GetCategories(fetchCategoriesRequest);
            return fetchCategoriesResponse;
        }

        [HttpPost()] // create a category
        public ActionResult<CreateCategoryResponse> CreateCategory(CreateCategoryRequest createCategoryRequest)
        {
            var createCategoryResponse = _categoryService.SaveCategory(createCategoryRequest);
            return createCategoryResponse;
        }

        [HttpPut()] // edit a category
        public ActionResult<UpdateCategoryResponse> UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            var updateCategoryResponse = _categoryService.EditCategory(updateCategoryRequest);
            return updateCategoryResponse;
        }

        [HttpDelete()] // delete a category
        public ActionResult<DeleteCategoryResponse> DeleteCategory(DeleteCategoryRequest deleteCategoryRequest)
        {
            var deleteCategoryResponse = _categoryService.DeleteCategory(deleteCategoryRequest);
            return deleteCategoryResponse;
        }


    }
}