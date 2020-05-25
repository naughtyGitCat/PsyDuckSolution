// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 11:26
// FileName:       HostUtil.cs
// Author:           psyduck007@outlook.com
// Purpose:         本机相关功能
// TODO:
// ////////////////////////////////////////////////////
//
//
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace DBACommonPackage.Utils
{
    public static class HostUtil
    {
        /// <summary>
        /// 获取主机名
        /// </summary>
        public static string LocalHostname
        {
            get { return Dns.GetHostName(); }
        }

        /// <summary>
        /// 获取本机IP
        /// </summary>
        public static string LocalIP
        {
            get
            {
                var bomList = Dns.GetHostAddresses(Dns.GetHostName());
                return bomList.FirstOrDefault(ha => ha.AddressFamily == AddressFamily.InterNetwork).ToString();
            }
        }
    }
}
