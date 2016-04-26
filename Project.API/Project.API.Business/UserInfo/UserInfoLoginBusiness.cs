using Project.API.Data.DataBase.UserInfo;
using Project.API.EntityFramework.Models;
using Project.API.ServiceModel.UserInfo;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.Business.UserInfo
{
    [Export(typeof(IUserInfoLoginBusiness))]       
    public class UserInfoLoginBusiness : IUserInfoLoginBusiness
    {
        private readonly IUserInfoDAL _userInfoDal;

        [ImportingConstructor]
        public UserInfoLoginBusiness(IUserInfoDAL userInfoDal)
        {
            _userInfoDal = userInfoDal;
        }
        public UserLoginResponse UserLogin(UserLoginRequest request)
        {
            UserLoginResponse response = new UserLoginResponse();
            UserInfoRequestModel userInfoModel = new UserInfoRequestModel();
            UserInfoResponseModel responseModel = new UserInfoResponseModel();
            userInfoModel = AutoMappingUtils.ConvertTo<UserInfoRequestModel>(request);
            response = AutoMappingUtils.ConvertTo<UserLoginResponse>(_userInfoDal.UserLogin(userInfoModel));

            return response;
        }
    }
}
