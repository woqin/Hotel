using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Util.Security
{
    public class EncryptionMD5
    {
        /// <summary>
        /// 获得一个字符串的加密密文
        /// 此密文为单向加密，即不可逆（解密）密文
        /// </summary>
        /// <param name="plainText">待加密明文</param>
        /// <returns>己加密密文</returns>
        public static string EncryptString(string plainText)
        {
            return EncryptStringMD5(plainText);
        }
        /// <summary>
        /// 获得一个字符串的加密密文
        /// 此密文为单向加密，即不可逆（解密）密文
        /// </summary>
        /// <param name="plainText">待加密明文</param>
        /// <returns>己加密密文</returns>
        public static string EncryptStringMD5(string plainText)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(plainText));
            StringBuilder encryptText = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                encryptText.Append(data[i].ToString("x2"));
            }
            return encryptText.ToString();
        }
        /// <summary>
        /// 判断明文与密文是否相符
        /// </summary>
        /// <param name="plainText">待检查的明文</param>
        /// <param name="encryptText">待检查的密文</param>
        /// <returns>bool</returns>
        public static bool EqualEncryptString(string plaintText,string encrypText)
        {
            return EqualEncryptStringMD5(plaintText, encrypText);
        }
        /// <summary>
        /// 判断明文与密文是否相符
        /// </summary>
        /// <param name="plainText">待检查的明文</param>
        /// <param name="encryptText">待检查的密文</param>
        /// <returns>bool</returns>
        private static bool EqualEncryptStringMD5(string plaintText, string encrypText)
        {
            bool result = false;
            if (string.IsNullOrEmpty(plaintText) || string.IsNullOrEmpty(encrypText))
            {
                return result;
            }
            result = EncryptStringMD5(plaintText).Equals(encrypText);
            return result;
        }
    }
}
