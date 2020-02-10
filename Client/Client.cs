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
        private String url = "http://localhost:5000/api/session/login";

        public bool makeRequest(LoginRequest requestObject)
        {
            try
            {
                MemoryStream outputStream = new MemoryStream();
                requestObject.WriteTo(new CodedOutputStream(outputStream));

                byte[] data = outputStream.ToArray();

                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "text/plain";
                webRequest.ContentLength = data.Length;
                using (Stream postStream = webRequest.GetRequestStream())
                {
                    // Send the data.
                    postStream.Write(data, 0, data.Length);
                    postStream.Close();
                }

                WebResponse response = webRequest.GetResponse();
                Console.WriteLine(UserSession.Parser.ParseFrom(response.GetResponseStream()).ToString());
                return true;
            }
            catch (Exception ex)
            {
                //Log exception here...
                return false;
            }
        }
}
}
