using Project.API.Business.UserInfo;
using Project.API.ServiceModel.UserInfo;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.ServiceInterface.UserInfo
{
    public class UserLoginServices : Service
    {
        private readonly IUserInfoLoginBusiness _userBusiness;

        [ImportingConstructor]
        public UserLoginServices(IUserInfoLoginBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        public object Any(UserLoginRequest request)
        {            
            UserLoginResponse response = new UserLoginResponse();
            response = _userBusiness.UserLogin(request);
            return response;
        }
    }
}
