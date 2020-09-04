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

    public class NotFindException : GenericException
    {
        public NotFindException() { }
        public NotFindException(string errMsg) : base(errMsg) { }
        public NotFindException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class DBRecordNotFindException : NotFindException
    {
        public DBRecordNotFindException() { }
        public DBRecordNotFindException(string errMsg) : base(errMsg) { }
        public DBRecordNotFindException(string message, Exception innerException) : base(message, innerException) { }
    }
}
