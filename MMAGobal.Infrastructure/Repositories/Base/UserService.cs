using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMAGlobal.Core.Entity;
using MMAGlobal.Core.Repositories.Base;

namespace MMAGlobal.Infrastructure.Repositories.Base
{
    public class UserService : IUserService
    {
        public LoginModel GetUserDetails()
        {
            return new LoginModel { UserName = "dulasi", Password = "Dulasi@123" };
        }

        public bool IsValidUserInformation(LoginModel model)
        {

            if (model.UserName.Equals("dulasi") && model.Password.Equals("Dulasi@123")) return true;
            else return false;
        }
    }
}
