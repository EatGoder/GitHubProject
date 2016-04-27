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
        UserInfoResponse UserLogin(UserLoginRequest request);

        UserInfoResponse UserRegister(UserRegisterRequest request);
    }
}
