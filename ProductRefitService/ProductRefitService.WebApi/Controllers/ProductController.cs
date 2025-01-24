using Microsoft.AspNetCore.Mvc;
using ProductRefitService.Infra.Features.Requests;
using ProductRefitService.Infra.Interfaces;

namespace ProductRefitService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public static class ProductController
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/Products", GetAllProducts);
            app.MapGet("/Product/{id}", GetProduct);
            app.MapPost("/Product", CreateProduct);
            app.MapPut("/Product", UpdateProduct);
            app.MapDelete("/Product/{id}", DeleteProduct);

        }

        [HttpGet]
        public static async Task<IResult> GetAllProducts(IProductRefit _productRefit)
        {
            try
            {
                var produto = await _productRefit.GetAllProducts().ConfigureAwait(false);
                if (produto == null) return Results.NotFound();

                return Results.Ok(produto);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }


        [HttpGet]
        private static async Task<IResult> GetProduct(GetProductRequest getProductRequest, IProductRefit _productRefit)
        {
            try
            {
                var produto = await _productRefit.GetProduct(getProductRequest).ConfigureAwait(false);
                if (produto == null)
                    return Results.NotFound();

                return Results.Ok(produto);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }



        [HttpPost]
        private static async Task<IResult> CreateProduct(CreateProductRequest createProductRequest, IProductRefit _productRefit)
        {
            try
            {
                var result = await _productRefit.CreateProduct(createProductRequest).ConfigureAwait(false);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }


        [HttpPut]
        private static async Task<IResult> UpdateProduct(UpdateProductRequest updateProductRequest, IProductRefit _productRefit)
        {
            try
            {
                var result = await _productRefit.UpdateProduct(updateProductRequest).ConfigureAwait(false);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }


        [HttpDelete]
        private static async Task<IResult> DeleteProduct(DeleteProductRequest deleteProductRequest, IProductRefit _productRefit)
        {
            try
            {
                var result = await _productRefit.DeleteProduct(deleteProductRequest).ConfigureAwait(false);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

    }
}
