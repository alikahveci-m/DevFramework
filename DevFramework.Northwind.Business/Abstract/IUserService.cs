using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Entities.ComplexTypes;
using DevFramework.Nortwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
