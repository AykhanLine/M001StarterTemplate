using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDal _userDal; //generate contructer ver

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetUserByEmail(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
