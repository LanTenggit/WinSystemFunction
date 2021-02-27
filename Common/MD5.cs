using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public  class MD5
    {


        #region 加密，(要加密的字符串)
        /// <summary>
        /// 加密，(要加密的字符串)
        /// </summary>
        /// <param name="pToEncrypt">要加密的字符串</param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string pToEncrypt)//加密，(要加密的字符串)
        {
            try
            {
                string sKey = "82350196";
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                StringBuilder ret = new StringBuilder();
                foreach (byte b in ms.ToArray())
                {
                    ret.AppendFormat("{0:X2}", b);
                }
                ret.ToString();
                return ret.ToString();
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 解密，(要解密的字符串)
        /// <summary>
        /// 解密，(要解密的字符串)
        /// </summary>
        /// <param name="pToDecrypt">要解密的字符串</param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public static string MD5Decrypt(string pToDecrypt)//解密，(要解密的字符串)
        {
            try
            {
                string sKey = "82350196";
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
                for (int x = 0; x < pToDecrypt.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                StringBuilder ret = new StringBuilder();
                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch
            {
                return null;
            }
        }
        #endregion


    }
}
