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
    public class UserRegisterServices : Service
    {
        private readonly IUserInfoLoginBusiness _userBusiness;

        [ImportingConstructor]
        public UserRegisterServices(IUserInfoLoginBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        public object Any(UserRegisterRequest request)
        {
            UserInfoResponse response = new UserInfoResponse();
            response = _userBusiness.UserRegister(request);
            return response;
        }
    }
}
