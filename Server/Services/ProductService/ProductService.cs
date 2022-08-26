namespace Ecommerce.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response=new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if(product != null)
            {
                response.Data=product;
            }
            else
            {
                response.Success=false;
                response.Message = "SORRY, BUT THIS PRODUCT DOES NOT EXIST.";
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {

            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .ToListAsync()
            };

            return response;
        }
    }
}
