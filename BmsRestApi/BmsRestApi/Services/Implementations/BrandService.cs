using BmsRestApi.Messages;
using BmsRestApi.Messages.Request.Brand;
using BmsRestApi.Messages.Response.Brand;
using BmsRestApi.Repositories;

namespace BmsRestApi.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private MessageMapper _messageMapper;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
            _messageMapper = new MessageMapper();
        }

        public CreateBrandResponse SaveBrand(CreateBrandRequest brandRequest)
        {
            var brand = _messageMapper.MapToBrand(brandRequest.Brand);
            _brandRepository.SaveBrand(brand);
            var brandDto = _messageMapper.MapToBrandDto(brand);

            var createBrandResponse = new CreateBrandResponse
            {
                Brand = brandDto
            };
            return createBrandResponse;
        }

        public UpdateBrandResponse EditBrand(UpdateBrandRequest updateBrandRequest)
        {
            UpdateBrandResponse updateBrandResponse = null;

            if (updateBrandRequest.Id == updateBrandRequest.Brand.Id)
            {
                var brand = _messageMapper.MapToBrand(updateBrandRequest.Brand);
                _brandRepository.UpdateBrand(brand);
                var brandDto = _messageMapper.MapToBrandDto(brand);

                updateBrandResponse = new UpdateBrandResponse
                {

                };
            }
            return updateBrandResponse;
        }

        public GetBrandResponse GetBrand(GetBrandRequest getBrandRequest)
        {
            GetBrandResponse getBrandResponse = null;

            if(getBrandRequest.Id > 0)
            {
                var brand = _brandRepository.FindBrandById(getBrandRequest.Id);
                var brandDto = _messageMapper.MapToBrandDto(brand);

                getBrandResponse = new GetBrandResponse
                {
                    Brand = brandDto
                };
            }
            return getBrandResponse;
        }

        public FetchBrandResponse GetBrands(FetchBrandsRequest fetchBrandsRequest)
        {
            var brands = _brandRepository.GetAllBrands();
            var brandDtos = _messageMapper.MapToBrandDto(brands);

            return new FetchBrandResponse
            {
                Brands = brandDtos
            };
        }

        public DeleteBrandResponse DeleteBrand(DeleteBrandRequest deleteBrandRequest)
        {
            var brand = _brandRepository.FindBrandById(deleteBrandRequest.Id);
            _brandRepository.DeleteBrand(brand);
            var brandDto = _messageMapper.MapToBrandDto(brand);

            return new DeleteBrandResponse
            {
                Brand = brandDto
            };
        }
    }
}
