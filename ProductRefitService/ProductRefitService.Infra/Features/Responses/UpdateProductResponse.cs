namespace ProductRefitService.Infra.Features.Responses
{
    public class UpdateProductResponse
    {
        public int id { get; set; }

        public string name { get; set; }

        public decimal price { get; set; }

        public decimal? priceMercadoLivre { get; set; }
    }
}
