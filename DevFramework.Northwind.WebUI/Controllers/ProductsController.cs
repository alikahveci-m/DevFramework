using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Business.Abstract;
using DevFramework.Nortwind.Entities.Concrete;
using System.Collections.Generic;
using System.Web.Http;

namespace DevFramework.Northwind.WebUI.Controllers
{
    public class ProductsController : ApiController
    {
        readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}
