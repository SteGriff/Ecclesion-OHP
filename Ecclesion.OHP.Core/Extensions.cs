using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core
{
    public static class Extensions
    {
        public static string GetMD5(this string content)
        {
            //Treat the content as UTF8 and get bytes
            var byteContent = Encoding.UTF8.GetBytes(content);

            //Hash the bytes 
            var md5er = MD5.Create();
            var hash = md5er.ComputeHash(byteContent);

            //Process the first half of the bytes (8/16)
            // translating them to hexadecimal rep.
            var sb = new StringBuilder();
            for(int i = 0; i < 8; i++)
            {
                sb.Append(hash[i].ToString("x").ToLower());
            }

            return sb.ToString();
        }
    }
}
