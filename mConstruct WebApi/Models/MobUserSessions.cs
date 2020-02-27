using System;
using System.Collections.Generic;

namespace mConstruct_WebApi.Models
{
    public partial class MobUserSessions
    {
        public string Userid { get; set; }
        public string Deviceid { get; set; }
        public string SessionToken { get; set; }
        public string Isactive { get; set; }
        public DateTime? Logintime { get; set; }
        public string MobAppKey { get; set; }
        public string FcmToken { get; set; }
    }
}
