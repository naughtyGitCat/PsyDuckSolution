// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 13:43
// FileName:       JsonUtil.cs
// Author:           psyduck007@outlook.com
// Purpose:         Json类, port json.net
// TODO:
// ////////////////////////////////////////////////////
//
//
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace DBACommonPackage.Utils
{
    /// <summary>
    /// 公用静态类
    /// </summary>
    public static class JsonUtil
    {
        /// <summary>
        /// 反序列化不区分大小写
        /// </summary>
        public static JsonSerializerOptions DeSerializerOptions { get; set; } = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        /// <summary>
        /// 序列化时不转义非ASCII字符
        /// </summary>
        public static JsonSerializerOptions SerializerOptions = new JsonSerializerOptions { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
    }
}
