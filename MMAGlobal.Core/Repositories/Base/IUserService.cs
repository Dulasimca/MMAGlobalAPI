using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMAGlobal.Core.Entity;

namespace MMAGlobal.Core.Repositories.Base
{
    public interface IUserService
    {
        bool IsValidUserInformation(LoginModel model);
        LoginModel GetUserDetails();
    }
}
