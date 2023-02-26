using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
