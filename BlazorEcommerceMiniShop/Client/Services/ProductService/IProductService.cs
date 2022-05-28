using BlazorEcommerceMiniShop.Shared;

namespace BlazorEcommerceMiniShop.Client.Services.ProductService
{
    public interface IProductService
    {

        public List<Product> Products { get; set; }

        Task GetProducts();

    }
}