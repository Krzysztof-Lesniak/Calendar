using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;

namespace Calendar
{
    public static class StringExtensionHashing
    {
        public static string ToSHA256(this string input)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha256.ComputeHash(bytes);

            return BitConverter.ToString(hash);
        }
       
    }
}
