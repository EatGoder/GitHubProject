using Project.API.EntityFramework.DbContext;
using Project.API.EntityFramework.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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


        public int UserInfoUpdate(UserInfoRequestModel request)
        {
            EntityFrameworkDbContext _db = new EntityFrameworkDbContext();
            //修改需要对主键赋值，注意：这里需要对所有字段赋值，没有赋值的字段会用NULL更新到数据库
            var user = new UserInfoResponseModel
            {
                UID = request.UID,
                UserNO = request.UserNO,
                UserName = request.UserName,
                UserEmail = request.UserEmail,
                PassWord = request.NewPassWord
            };
            //将实体附加到对象管理器中
            _db.UserInfo.Attach(user);

            //获取到状态实体，可以修改其状态
            var setEntry = ((IObjectContextAdapter)_db).ObjectContext.ObjectStateManager.GetObjectStateEntry(user);
            //只修改实体属性
            setEntry.SetModifiedProperty("PassWord");

            return _db.SaveChanges();

        }
    }
}
