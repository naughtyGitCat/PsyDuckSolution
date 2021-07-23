// ////////////////////////////////////////////////////
// StartTime:      2020/9/3 14:56
// FileName:       StringMD5HashExtensions.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DBACommonPackage.Extensions
{
    public static class StringMD5HashExtensions
    {
        public static string GenMD5Hash(this string rawStr)
        {
            using var md5 = MD5.Create();
            var hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(rawStr));
            var hexDigest = string.Join("", hashedBytes.Select(x => x.ToString("X2"))).ToLower();
            return hexDigest;
        }

        public static string GenSHA1Hash(this string input)
        {
            using var sha1 = new SHA1Managed();
            var hashedBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            var hexDigest = string.Join("", hashedBytes.Select(x => x.ToString("X2"))).ToLower();
            return hexDigest;
        }
    }
}
