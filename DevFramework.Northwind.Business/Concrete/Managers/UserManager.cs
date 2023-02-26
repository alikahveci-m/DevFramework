using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.ComplexTypes;
using DevFramework.Nortwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Nortwind.Business.Concrate.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}