using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User UserGetFirstOrDefaultLogin(User user)
        {
            return _userDal.GetFirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

        public User GetUserByUserName(string username)
        {
         return   _userDal.Get(x => x.UserName == username);
        }

        public List<User> UserList()
        {
            return _userDal.List();
        }

        public User GetUserById(int id)
        {
            return _userDal.Get(x => x.UserID == id);
        }
    }
}
