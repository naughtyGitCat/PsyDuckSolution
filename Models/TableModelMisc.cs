// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 11:24
// FileName:       TableModelMisc.cs
// Author:           psyduck007@outlook.com
// Purpose:         表模型其他
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
namespace DBACommonPackage.Models
{
    public abstract class ModelHistory
    {
        public string DeleteBy { get; set; } = "";
        public DateTime DeleteTime { get; set; } = DateTime.Now;
    }

    public abstract class ModelFootPrintFields
    {
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }

    public abstract class ModelEnvironment
    {
        public string Environment { get; set; }
    }
}
