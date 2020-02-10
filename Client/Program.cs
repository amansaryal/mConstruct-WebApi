using Grpc.services;
using Session_WebApi;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApiLibrary
{
    class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            LoginRequest request = new LoginRequest();
            request.AppName = Appname.Mconstruct;
            request.Username = "aman.saryal";
            request.Password = "aman.saryal";
            request.Imei = "aman.saryal";
            request.IpAddress = "aman.saryal";

             
            new Client().makeRequest(request);

        }
    }
}
