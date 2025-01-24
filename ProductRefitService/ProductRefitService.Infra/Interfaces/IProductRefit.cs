using ProductRefitService.Infra.Features.Requests;
using ProductRefitService.Infra.Features.Responses;
using Refit;

namespace ProductRefitService.Infra.Interfaces
{
    public interface IProductRefit
    {
        [Get("/Product/{id}")]
        Task<GetProductResponse> GetProduct(GetProductRequest getProductRequest);

        [Get("/Products")]
        Task<GetAllProductsResponse> GetAllProducts();

        [Post("/Product")]
        Task<CreateProductResponse> CreateProduct([Body] CreateProductRequest createProductRequest);

        [Put("/Product")]
        Task<UpdateProductResponse> UpdateProduct([Body] UpdateProductRequest updateProductRequest);

        [Delete("/Product/{id}")]
        Task<string> DeleteProduct(DeleteProductRequest deleteProductRequest);
    }
}
