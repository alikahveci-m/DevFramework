using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}