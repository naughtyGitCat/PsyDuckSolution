// ////////////////////////////////////////////////////
// StartTime:      2020/6/6 15:51
// FileName:       JsonElementExtensions.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//
using System.Text.Json;

namespace DBACommonPackage.Extensions
{
    public static class JsonElementExtensions
    {
        /// <summary>
        /// 从string类型的JsonElement中解析出double类型
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static double ParseStringElementToDouble(this JsonElement element)
        {
            return float.Parse(element.GetString());
        }
    }
}
