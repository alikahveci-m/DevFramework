using System.Collections.Generic;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.ComplexTypes;
using DevFramework.Nortwind.Entities.Concrete;
using System.Linq;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ur in context.Roles
                             join r in context.UserRoles
                             on ur.UserId equals user.Id
                             where ur.UserId == user.Id
                             select new UserRoleItem
                             {
                                 RoleName = r.RoleName,
                             };
                return result.ToList();
            }
        }
    }
}