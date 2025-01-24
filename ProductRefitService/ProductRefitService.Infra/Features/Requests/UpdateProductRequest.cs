namespace ProductRefitService.Infra.Features.Requests
{
    public class UpdateProductRequest
    {
        public int id { get; set; }

        public string name { get; set; }

        public decimal price { get; set; }

    }
}
