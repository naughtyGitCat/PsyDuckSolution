// ////////////////////////////////////////////////////
// StartTime:      2020/6/18 16:00
// FileName:       Setting.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
namespace DBACommonPackage.Models
{
    public class HostPort
    {
        public string Host { get; set; }
        public int Port { get; set; }
    }
    public class HTTPSimpleAPI : HostPort
    {
        public string Protocol { get; set; }
        public string APIPath { get; set; }
    }
}
