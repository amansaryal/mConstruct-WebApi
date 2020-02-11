using System;
using System.Security.Cryptography;
using System.Text;

namespace MobileWebApiLibrary
{
    public class EncryptionHelper
    {

        private static string IV = "$rjil@123456789$";
        private static string SALT = "S@1tS@1t";
        private static string PASSWORD = "Pass@word1";
        private static int ITERATIONS = 256;

        public static byte[] EncryptCode(byte[] data)
        {
            using (var csp = new AesCryptoServiceProvider())
            {
                ICryptoTransform e = GetCryptoTransform(csp, true);
                return e.TransformFinalBlock(data, 0, data.Length);
            }
        }

        public static byte[] DecryptCode(byte[] data)
        {
            using (var csp = new AesCryptoServiceProvider())
            {
                try
                {
                
                var d = GetCryptoTransform(csp, false);              
                return d.TransformFinalBlock(data, 0, data.Length); ;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private static ICryptoTransform GetCryptoTransform(AesCryptoServiceProvider csp, bool encrypting)
        {
            csp.Mode = CipherMode.CBC;
            csp.Padding = PaddingMode.PKCS7;
           

            var spec = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(PASSWORD), Encoding.UTF8.GetBytes(SALT), int.Parse(Convert.ToString(ITERATIONS)));
            byte[] key = spec.GetBytes(16);

            csp.IV = Encoding.UTF8.GetBytes(IV);
            csp.Key = key;
            if (encrypting)
            {
                return csp.CreateEncryptor();
            }
            return csp.CreateDecryptor();
        }

    }
}