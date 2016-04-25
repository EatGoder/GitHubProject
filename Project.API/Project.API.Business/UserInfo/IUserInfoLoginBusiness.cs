using Project.API.EntityFramework.Models;
using Project.API.ServiceModel.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.Business.UserInfo
{
    public interface IUserInfoLoginBusiness
    {
        UserLoginResponse UserLogin(UserLoginRequest request);
    }
}
