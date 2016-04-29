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
    public class UserInfoUpdateServices: Service
    {
        private readonly IUserInfoBusiness _userBusiness;

        [ImportingConstructor]
        public UserInfoUpdateServices(IUserInfoBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        public object Any(UserInfoUpdateRequest request)
        {
            return _userBusiness.UserInfoUpdate(request);
        }
    }
}
