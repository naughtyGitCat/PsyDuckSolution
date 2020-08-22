// ////////////////////////////////////////////////////
// StartTime:      2020/8/22 18:24
// FileName:       GenericExceptions.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
namespace DBACommonPackage.Exceptions
{
    public class GenericException : Exception
    {
        public GenericException() { }
        public GenericException(string errMsg) : base(errMsg) { }
        public GenericException(string message, Exception innerException) : base(message, innerException) { }
    }
}
