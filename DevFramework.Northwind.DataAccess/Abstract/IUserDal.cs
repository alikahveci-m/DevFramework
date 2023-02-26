using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Entities.ComplexTypes;
using DevFramework.Nortwind.Entities.Concrete;
using NHibernate.Mapping;
using System.Collections.Generic;

namespace DevFramework.Nortwind.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}