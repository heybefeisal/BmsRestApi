using BmsRestApi.Messages.Request.Product;
using BmsRestApi.Messages.Response.Product;

namespace BmsRestApi.Services
{
    public interface ICatalogueService
    {
        FetchProductResponse FetchProducts(FetchProductsRequest fetchProductsRequest);
    }
}
