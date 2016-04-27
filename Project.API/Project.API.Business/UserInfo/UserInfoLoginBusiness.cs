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
        public UserInfoResponse UserLogin(UserLoginRequest request)
        {
            UserInfoRequestModel userInfoModel = AutoMappingUtils.ConvertTo<UserInfoRequestModel>(request);
            UserInfoResponse response = AutoMappingUtils.ConvertTo<UserInfoResponse>(_userInfoDal.UserLogin(userInfoModel));

            return response;
        }


        public UserInfoResponse UserRegister(UserRegisterRequest request)
        {
            string userNo = "E" + DateTime.Now.ToString("yyyyMMddHHmmss");
            UserInfoRequestModel userInfoModel = AutoMappingUtils.ConvertTo<UserInfoRequestModel>(request);
            userInfoModel.UserNO = userNo;
            UserInfoResponse response = AutoMappingUtils.ConvertTo<UserInfoResponse>(_userInfoDal.UserRegister(userInfoModel));

            return response;
        }
    }
}
