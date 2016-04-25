using Project.API.Business.UserInfo;
using Project.API.ServiceModel.UserInfo;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.ServiceInterface.UserInfo
{
    public class UserLoginServices : Service
    {
        public object Any(UserLoginRequest request)
        {
            IUserInfoLoginBusiness _userInfo = new UserInfoLoginBusiness();
            UserLoginResponse response = new UserLoginResponse();
            response = _userInfo.UserLogin(request);
            return response;
        }
    }
}
