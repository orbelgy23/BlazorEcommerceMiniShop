using BlazorEcommerceMiniShop.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerceMiniShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        private readonly HttpClient _http;


        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<List<Product>>("api/product");
            if (result != null)
            {
                Products = result;
            }
        }
    }
}
