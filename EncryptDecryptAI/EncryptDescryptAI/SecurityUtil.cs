using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
namespace EncryptDescryptAI
{
    public class SecurityUtil
    {
        /// <summary>
        ///     Encrypt string with DES Algorithm
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool TryEncrypt(string toEncrypt,
                                     string key, out string textEncrypted)
        {
            try
            {


                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(key + toEncrypt);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
                {
                    Key = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key)),
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };

                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                textEncrypted = Convert.ToBase64String(resultArray, 0, resultArray.Length);
                return true;

            }
            catch (Exception)
            {
                textEncrypted = string.Empty;
                return false;
            }
        }

        /// <summary>
        ///     Decrypt string with DES Algorithm
        /// </summary>
        /// <param name="toDecrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool TryDecrypt(string toDecrypt,
                                     string key, out string txtDecrypted)
        {
            try
            {
                byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
                {
                    Key = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
                };
                ;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                var result = UTF8Encoding.UTF8.GetString(resultArray);

                txtDecrypted = result.Substring(key.Length);
                return true;
            }
            catch (Exception)
            {
                txtDecrypted = string.Empty;
                return false;
            }
        }
    }
}
