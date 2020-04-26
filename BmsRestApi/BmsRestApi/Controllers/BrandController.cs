using BmsRestApi.Messages.Request.Brand;
using BmsRestApi.Messages.Response.Brand;
using BmsRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BmsRestApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        } 

        [HttpGet(template:"{id}")] // get brand by id
        public ActionResult<GetBrandResponse> GetBrand(long id)
        {
            var getBrandRequest = new GetBrandRequest
            {
                Id = id
            };
            var getBrandResponse = _brandService.GetBrand(getBrandRequest);
            return getBrandResponse;
        }

        [HttpGet()] // get all brands
        public ActionResult<FetchBrandResponse> GetBrands()
        {
            var fetchBrandsRequest = new FetchBrandsRequest { };
            var fetchBrandResponse = _brandService.GetBrands( fetchBrandsRequest);
            return fetchBrandResponse;
        }

        [HttpPost] // create a brand
        public ActionResult<CreateBrandResponse> PostBrand(CreateBrandRequest createBrandsRequest) //Model binding
        {
            var createBrandResponse = _brandService.SaveBrand(createBrandsRequest);
            return createBrandResponse;
        }

        [HttpPut()] // edit a brand
        public ActionResult<UpdateBrandResponse> UpdateBrand(UpdateBrandRequest updateBrandRequest)
        {
            var updateBrandResponse = _brandService.EditBrand(updateBrandRequest);
            return updateBrandResponse;
        }

        [HttpDelete(template:"{id}")] // delete a brand
        public ActionResult<DeleteBrandResponse> DeleteBrand(long id)
        {
            var deleteBrandRequest = new DeleteBrandRequest
            {
                Id = id
            };
            var deleteBrandResponse = _brandService.DeleteBrand(deleteBrandRequest);
            return deleteBrandResponse;
        }
    }
}