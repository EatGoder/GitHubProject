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
        private readonly IUserInfoBusiness _userBusiness;

        [ImportingConstructor]
        public UserLoginServices(IUserInfoBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        public object Any(UserLoginRequest request)
        {
            UserInfoResponse response = new UserInfoResponse();
            response = _userBusiness.UserLogin(request);
            return response;
        }
    }
}
