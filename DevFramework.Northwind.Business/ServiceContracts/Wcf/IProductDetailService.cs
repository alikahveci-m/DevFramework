using DevFramework.Nortwind.Entities.Concrete;
using System.Collections.Generic;
using System.ServiceModel;

namespace DevFramework.Northwind.Business.ServiceContracts.Wcf
{
    [ServiceContract]
    public interface IProductDetailService
    {
        [OperationContract]
        List<Product> GetAll();
    }
}
