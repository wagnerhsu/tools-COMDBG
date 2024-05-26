using System;
using System.Text;

namespace ComDbgCommon
{
    public static class ConvertUtility
    {
        /// <summary>
        /// Convert hex string to byte array.
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] HexToByteArray(string hex)
        {
            hex = hex.Replace("-", "").Replace(" ","");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                try
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                catch (System.Exception)
                {
                    //Do Nothing
                }
            }

            return raw;
        }

        /// <summary>
        /// Convert byte[] to hex string.
        /// </summary>
        /// <param name="byArray"></param>
        /// <returns></returns>
        public static string ByteArrayToHex(byte[] byArray)
        {
            return BitConverter.ToString(byArray).Replace("-"," ");
        }

        /// <summary>
        /// Convert string to hex according to the code page.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="codePage"></param>
        /// <returns></returns>
        public static string StringToHex(string data, int codePage = 20127)
        {
            return ByteArrayToHex(Encoding.GetEncoding(codePage).GetBytes(data));
        }

        /// <summary>
        /// Convert 
        /// </summary>
        /// <param name="hex"></param>
        /// <param name="codePage"></param>
        /// <returns></returns>
        public static string HexToString(string hex, int codePage = 20127)
        {
            var byArray = HexToByteArray(hex);
            return Encoding.GetEncoding(codePage).GetString(byArray);
        }
    }
}