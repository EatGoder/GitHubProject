using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.API.EntityFramework.Models
{
    public class UserInfoRequestModel
    {
        public Int64 UID { get; set; }
        public string UserName { get; set; }

        public string UserNO { get; set; }

        public string PassWord { get; set; }

        public string NewPassWord { get; set; }

        public string UserEmail { get; set; }
    }
    public class UserInfoResponseModel
    {
        public Int64 UID { get; set; }
        public string UserNO { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string PassWord { get; set; }
    }
}
