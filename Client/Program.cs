using Grpc.services;
using Session_WebApi;

namespace MobileWebApiLibrary
{
    class Program
    {
        public static void Main(string[] args)
        {
            LoginRequest request = new LoginRequest();
            request.AppName = Appname.Mconstruct;
            request.Username = "aman.saryal";
            request.Password = "aman.saryal";
            request.Imei = "aman.saryal";
            request.IpAddress = "aman.saryal";

             
            new Client().makeEncryptedRequest(request);

        }
    }
}
