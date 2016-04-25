using Project.API.EntityFramework.DbContext;
using Project.API.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.Data.DataBase.UserInfo
{
    public class UserInfoDAL : IUserInfoDAL
    {
        public UserInfoResponseModel UserLogin(UserInfoRequestModel request)
        {
            UserInfoResponseModel response = new UserInfoResponseModel();
            EntityFrameworkDbContext db = new EntityFrameworkDbContext();
            var obj = db.UserInfo.ToList().Find(i=>i.UserName == request.UserName);
            return response;
        }
    }
}
