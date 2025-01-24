namespace ProductRefitService.Infra.Features.Responses
{
    public class GetProductResponse
    {
            public int id { get; set; }

            public string name { get; set; }

            public decimal price { get; set; }

            public decimal? priceMercadoLivre { get; set; }        
    }
}
