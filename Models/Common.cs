// ////////////////////////////////////////////////////
// StartTime:      2020/6/4 15:11
// FileName:       Common.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//

namespace DBACommonPackage.Models
{
    public class NameValue<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
