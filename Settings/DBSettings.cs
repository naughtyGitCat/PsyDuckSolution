// ////////////////////////////////////////////////////
// StartTime:      2020/9/4 15:25
// FileName:       DBSettings.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
using System.Collections.Generic;

namespace DBACommonPackage.Settings
{
    /// <summary>
    /// Redis Configuration / Redis配置
    /// </summary>
    public class RedisSetting
    {
        public IEnumerable<string> InstanceList { get; set; }
        public string Password { get; set; }
        public bool AdminCommandEnable { get; set; }
        public bool UseSentinel { get; set; }
        public string SentinelRegisterName { get; set; }
        public int DatabaseNumber { get; set; }
    }
}
