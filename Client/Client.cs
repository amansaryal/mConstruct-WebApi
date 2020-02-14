using Google.Protobuf;
using Grpc.services;
using MobileWebApiLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Session_WebApi
{
    public class Client
{
        private String url = "http://localhost:5000/test/login";

        public void makeRequest(LoginRequest requestObject)
        {
            try
            {
                byte[] data = requestObject.ToByteArray();

                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/protobuf";
                webRequest.Accept = "application/protobuf";
                webRequest.ContentLength = data.Length;
                using (Stream postStream = webRequest.GetRequestStream())
                {
                    // Send the data.
                    postStream.Write(data, 0, data.Length);
                    postStream.Close();
                }

                Console.WriteLine(requestObject.ToString());

                Console.WriteLine(UserSession.Parser.ParseFrom(webRequest.GetResponse().GetResponseStream()).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex:" + ex.Message);
                
            }
        }

        public void makeEncryptedRequest(LoginRequest requestObject)
        {
            try
            {
                byte[] data = EncryptionHelper.EncryptCode(requestObject.ToByteArray());

                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/protobuf";
                webRequest.Accept = "application/protobuf";
                webRequest.Headers.Add("X-Secure", "true");
                webRequest.ContentLength = data.Length;
                using (Stream postStream = webRequest.GetRequestStream())
                {
                    // Send the data.
                    postStream.Write(data, 0, data.Length);
                    postStream.Close();
                }

                Console.WriteLine(requestObject.ToString());

                WebResponse httpResponse = webRequest.GetResponse();

                //decrypt response
                byte[] decryptedResponse = EncryptionHelper.DecryptCode(StreamHelper.ReadFully(httpResponse.GetResponseStream()));

                Console.WriteLine(UserSession.Parser.ParseFrom(decryptedResponse).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex:" + ex.Message);

            }
        }

        public void makeJsonRequest(LoginRequest requestObject)
        {
            try
            {
                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";
                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {

                    streamWriter.Write(requestObject.ToString());
                    streamWriter.Flush();
                }
                WebResponse httpResponse = webRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex:" + ex.Message);

            }
        }

        public void makeEncryptedJsonRequest(LoginRequest requestObject)
        {
            try
            {
                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";
                webRequest.Headers.Add("X-Secure", "true");

                //encrypt request
                byte[] encryptedRequest = EncryptionHelper.EncryptCode(Encoding.UTF8.GetBytes(requestObject.ToString()));

                webRequest.GetRequestStream().Write(encryptedRequest, 0, encryptedRequest.Length);

                WebResponse httpResponse = webRequest.GetResponse();

                byte[] decryptedResponse = EncryptionHelper.DecryptCode(StreamHelper.ReadFully(httpResponse.GetResponseStream()));
                
                Console.WriteLine(Encoding.UTF8.GetString(decryptedResponse));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex:" + ex.Message);

            }
        }

        public void makeEncryptedProtoJsonRequest(LoginRequest requestObject)
        {
            try
            {
                // Prepare web request...
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/proto+json";
                webRequest.Accept = "application/proto+json";
                webRequest.Headers.Add("X-Secure", "true");

                //encrypt request
                byte[] encryptedRequest = EncryptionHelper.EncryptCode(Encoding.UTF8.GetBytes(requestObject.ToString()));

                webRequest.GetRequestStream().Write(encryptedRequest, 0, encryptedRequest.Length);

                WebResponse httpResponse = webRequest.GetResponse();

                byte[] decryptedResponse = EncryptionHelper.DecryptCode(StreamHelper.ReadFully(httpResponse.GetResponseStream()));

                Console.WriteLine(Encoding.UTF8.GetString(decryptedResponse));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex:" + ex.Message);

            }
        }
    }
}
