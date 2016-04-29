using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.ServiceModel.UserInfo
{
    public class UserLoginRequest : IReturn<UserInfoResponse>
    {
        public string UserName { get; set; }

        public string PassWord { get; set; }

    }

    public class UserRegisterRequest : IReturn<UserInfoResponse>
    {
        public string UserName { get; set; }

        public string UserNO { get; set; }

        public string PassWord { get; set; }

        public string UserEmail { get; set; }
    }

    public class UserInfoUpdateRequest : IReturn<UserInfoResponse>
    {
        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string NewPassWord { get; set; }

    }

    public class UserInfoResponse
    {
        public Int64 UID { get; set; }
        public string UserName { get; set; }

        public string UserNO { get; set; }

        public string PassWord { get; set; }

        public string UserEmail { get; set; }
    }
}
