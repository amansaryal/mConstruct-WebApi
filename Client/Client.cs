using Google.Protobuf;
using Grpc.services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Session_WebApi
{
    public class Client
{
        private String url = "http://localhost:5000/api/session";

        public void makeRequest(LoginRequest requestObject)
        {
            try
            {
                byte[] data = requestObject.ToByteArray();

                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-protobuf";
                webRequest.ContentLength = data.Length;
                using (Stream postStream = webRequest.GetRequestStream())
                {
                    // Send the data.
                    postStream.Write(data, 0, data.Length);
                    postStream.Close();
                }

                
                Console.WriteLine(UserSession.Parser.ParseFrom(webRequest.GetResponse().GetResponseStream()).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex:" + ex.Message);
                
            }
        }
}
}
