
namespace ProductRefitService.Infra.Features.Responses
{
    public class GetAllProductsResponse
    {
        IEnumerable<GetAllProductResponse>? getAllProductResponse { get; set; }
        private class GetAllProductResponse
        {
            public string name { get; set; }

            public decimal price { get; set; }

            public decimal? priceMercadoLivre { get; set; }
        }
    }
}
