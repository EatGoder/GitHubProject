using Project.API.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.Data.DataBase.UserInfo
{
    public interface IUserInfoDAL
    {
        UserInfoResponseModel UserLogin(UserInfoRequestModel request);
    }
}
