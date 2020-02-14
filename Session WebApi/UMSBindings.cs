using Grpc.services;
using System.Collections.Generic;

namespace Session_WebApi
{
    public static class UMSBindings
    {
        public static Dictionary<Appname, string> UmsAppUrlMap = new Dictionary<Appname, string>
        {
            {Appname.Mconstruct, "" },
            {Appname.Onmrfs, "https://nvmbd1bkh150v02.in.ril.com/OnMRFS" },
        };

        public static Dictionary<Appname, string> BackwardsCompatibleAppnames = new Dictionary<Appname, string>
        {
            {Appname.Mconstruct, "FttxmConstruct" },
            {Appname.Onmrfs, "onmrfs" },
        };


    }
}
