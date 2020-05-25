// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 11:23
// FileName:       QueryRequest.cs
// Author:           psyduck007@outlook.com
// Purpose:         请求模型
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
namespace DBACommonPackage.Models
{
    public interface IPagerQueryParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class PagerMisc : IPagerQueryParameter
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 8;
    }
    public interface IOrderQueryParameter
    {
        public string OrderColumn { get; set; }
        public string OrderDirection { get; set; }
    }
    public class OrderMisc : IOrderQueryParameter
    {
        public string OrderColumn { get; set; } = "id";
        public string OrderDirection { get; set; } = "DESC";
    }
    public interface IPagerOrderQueryParameter : IOrderQueryParameter, IPagerQueryParameter { }

    public class BaseQueryParameter : IPagerOrderQueryParameter
    {
        // PAGER
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 8;
        // ORDER
        public string OrderColumn { get; set; } = "id";
        public string OrderDirection { get; set; } = "DESC";
        // FILTER
    }
}
