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
    [Export(typeof(IUserInfoBusiness))]       
    public class UserInfoBusiness : IUserInfoBusiness
    {
        private readonly IUserInfoDAL _userInfoDal;

        [ImportingConstructor]
        public UserInfoBusiness(IUserInfoDAL userInfoDal)
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


        public int UserInfoUpdate(UserInfoUpdateRequest request)
        {
            UserLoginRequest userInfoReq = new UserLoginRequest();
            userInfoReq.UserName = request.UserName;
            userInfoReq.PassWord = request.PassWord;

            UserInfoResponse userInfoRes = UserLogin(userInfoReq);
            UserInfoRequestModel userInfoModel = AutoMappingUtils.ConvertTo<UserInfoRequestModel>(request);
            if (userInfoRes != null)
            {
                userInfoModel.UID = userInfoRes.UID;
                userInfoModel.UserNO = userInfoRes.UserNO;
                userInfoModel.UserName = userInfoRes.UserName;
                userInfoModel.UserEmail = userInfoRes.UserEmail;
                userInfoModel.PassWord = request.NewPassWord;
                
                return _userInfoDal.UserInfoUpdate(userInfoModel);
            }
            else {
                return 0;
            }
        }
    }
}
