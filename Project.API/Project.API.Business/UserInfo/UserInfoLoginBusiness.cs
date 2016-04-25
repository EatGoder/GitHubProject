using Project.API.Data.DataBase.UserInfo;
using Project.API.EntityFramework.Models;
using Project.API.ServiceModel.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.Business.UserInfo
{
    public class UserInfoLoginBusiness : IUserInfoLoginBusiness
    {
        public UserLoginResponse UserLogin(UserLoginRequest request)
        {
            UserLoginResponse response = new UserLoginResponse();
            UserInfoRequestModel userInfoModel = new UserInfoRequestModel();
            UserInfoResponseModel responseModel = new UserInfoResponseModel();
            IUserInfoDAL _dal = new UserInfoDAL();

            userInfoModel.UserName = request.UserName;
            responseModel = _dal.UserLogin(userInfoModel);

            return response;
        }
    }
}
