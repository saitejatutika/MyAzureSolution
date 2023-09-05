using WebAppWithSqlDb.Models;

namespace WebAppWithSqlDb.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
