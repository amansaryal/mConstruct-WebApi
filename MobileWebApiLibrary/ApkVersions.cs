﻿using Grpc.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWebApiLibrary
{
    public static class ApkVersions
    {
        public static Dictionary<Appname, int> appVersionMappings = new Dictionary<Appname, int>
        {
            {Appname.Mconstruct, 23 },
            {Appname.Onmrfs, 4 }
        };
    }
}
