// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 11:26
// FileName:       HostUtil.cs
// Author:           psyduck007@outlook.com
// Purpose:         本机相关功能
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using DBACommonPackage.Models;

namespace DBACommonPackage.Utils
{
    [Obsolete("Deprecated, use HostInfoFactory instead of it", error:false)]
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
    public static class HostInfoFactory
    {
        /// <summary>
        /// like darwin/linux/windows
        /// </summary>
        /// <returns></returns>
        public static string ReadOSType()
        {
            var rawString = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            return rawString.Split(" ")[0].ToLower();
        }
        /// <summary>
        /// use dns,in danger of cache
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIPByDNS()
        {
            var bomList = Dns.GetHostAddresses(Dns.GetHostName());
            return bomList.FirstOrDefault(ha => ha.AddressFamily == AddressFamily.InterNetwork).ToString();
        }
        /// <summary>
        /// use socket
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIPBySocket()
        {
            string ip = "127.0.0.1";
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 0);
                sock.Bind(localEndPoint);
                localEndPoint = (IPEndPoint)sock.LocalEndPoint;
                ip = localEndPoint.Address.ToString();
            }
            finally
            {
                sock.Close();
            }
            return ip;
        }

        public static HostInfo FetchHostInfo(bool useSocket = false)
        {
            return new HostInfo
            {
                OSType = ReadOSType(),
                HostIP = useSocket ? GetLocalIPBySocket() : GetLocalIPByDNS(),
                HostName = Dns.GetHostName()
            };
        }
        /// <summary>
        /// find free port with no lock
        /// the port might be occupied when u really start to use it
        /// </summary>
        /// <returns></returns>
        public static int FindFreePort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }
    }
}
