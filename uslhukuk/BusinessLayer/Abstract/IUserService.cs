using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        User UserGetFirstOrDefaultLogin(User user);
        List<User> UserList();
        void UpdateUser(User user);
        User GetUserByUserName(string username);
        User GetUserById(int id);
    }
}
