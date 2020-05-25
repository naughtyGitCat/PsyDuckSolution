// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 13:42
// FileName:       Object.cs
// Author:           psyduck007@outlook.com
// Purpose:        Help for debug print
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
using System.Text.Json;
using DBACommonPackage.Utils;

namespace DBACommonPackage.Common
{
    public class CommonObject
    {
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, JsonUtil.SerializerOptions);
        }
    }
}
