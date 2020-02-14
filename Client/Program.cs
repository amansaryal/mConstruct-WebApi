using Grpc.services;
using Session_WebApi;

namespace MobileWebApiLibrary
{
    class Program
    {
        public static void Main(string[] args)
        {
            LoginRequest request = new LoginRequest();
            request.AppName = Appname.Onmrfs;
            request.Username = "aman.saryal";
            request.Password = "2wsxcvbnm,";
            request.Imei = "2345";
            request.IpAddress = "23456";
            request.AppVersion = 4;

             
            new Client().makeEncryptedRequest(request);

        }
    }
}
