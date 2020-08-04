// ////////////////////////////////////////////////////
// StartTime:      2020/8/4 20:24
// FileName:       HostInfo.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//

namespace DBACommonPackage.Models
{
    public class HostInfo
    {
        public string HostName { get; set; }
        public string HostIP { get; set; }
        /// <summary>
        /// like darwin/linux/windows
        /// </summary>
        public string OSType { get; set; }
    }
}
