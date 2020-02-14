using System;
using System.Collections.Generic;

namespace Session_WebApi.Models
{
    public partial class Usersessioninfo
    {
        public string Userid { get; set; }
        public string Deviceid { get; set; }
        public string Sessionkey { get; set; }
        public string Isactive { get; set; }
        public DateTime? Logintime { get; set; }
        public string Appname { get; set; }
        public string FcmToken { get; set; }
    }
}
