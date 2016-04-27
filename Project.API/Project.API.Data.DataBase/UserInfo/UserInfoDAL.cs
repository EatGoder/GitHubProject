using Project.API.EntityFramework.DbContext;
using Project.API.EntityFramework.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.Data.DataBase.UserInfo
{
    [Export(typeof(IUserInfoDAL))]      
    public class UserInfoDAL : IUserInfoDAL
    {
        private readonly EntityFrameworkDbContext db;

        public UserInfoDAL()
        {
            db = new EntityFrameworkDbContext();
        }
        public UserInfoResponseModel UserLogin(UserInfoRequestModel request)
        {
            var obj = db.UserInfo.ToList().Find(i=>i.UserName == request.UserName);
            UserInfoResponseModel response = AutoMappingUtils.ConvertTo<UserInfoResponseModel>(obj);
            return response;
        }


        public UserInfoResponseModel UserRegister(UserInfoRequestModel request)
        {
            UserInfoResponseModel response = new UserInfoResponseModel();
            UserInfoResponseModel userData = new UserInfoResponseModel() { UserName = request.UserName, UserNO = request.UserNO, PassWord = request.PassWord };
            db.UserInfo.Add(userData);
            int result = db.SaveChanges();

            if (result == 1)
            {
                response.UserNO = request.UserNO;
            }
            return response;
        }
    }
}
