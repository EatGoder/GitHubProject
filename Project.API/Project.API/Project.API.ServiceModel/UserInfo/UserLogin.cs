using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.ServiceModel.UserInfo
{
    public class UserLoginRequest : IReturn<UserLoginResponse>
    {
        public string UserName { get; set; }
    }
    public class UserLoginResponse
    {
        public Int64 UID { get; set; }
        public string UserNO { get; set; }
        public string UserName { get; set; }
    }
}
