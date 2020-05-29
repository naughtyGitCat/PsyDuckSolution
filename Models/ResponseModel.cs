// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 11:25
// FileName:       ResponseModel.cs
// Author:           psyduck007@outlook.com
// Purpose:         响应模型
// TODO:
// ////////////////////////////////////////////////////
//
//
using System.Collections.Generic;

namespace DBACommonPackage.Models
{
    public class StandardResponse<T>
    {
        public int StatusCode { get; set; }
        public T Data { get; set; }
        public string ErrMsg { get; set; }
    }

    public class RowsWithTotalCount<T>
    {
        public IEnumerable<T> Rows { get; set; }
        public int Count { get; set; }
    }
}
