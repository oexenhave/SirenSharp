namespace SirenSharp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents possible error codes for envelope error messages
    /// </summary>
    public enum ErrorCode
    {
        Success = 0,
        InternalAccessOnly = 1000,
        HashInvalid = 1001,
        CredentialsInvalid = 1002,
        RequestNotValidAnymore = 1003,
        ParameterInvalid = 1004
    }

    /// <summary>
    /// This class is used for error messages returned in the JSON part of the API
    /// </summary>
    public class SirenException : SirenEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SirenException"/> class.
        /// </summary>
        public SirenException(Exception exception)
        {
            this.AddClass("exception");

            this.Properties.Message = exception.Message;
            this.Properties.Type = exception.GetType();
            this.Properties.StackTrace = exception.StackTrace;

            if (exception.InnerException != null)
            {
                this.Properties.InnerMessage = exception.InnerException.Message;
                this.Properties.InnerType = exception.InnerException.GetType();
                this.Properties.InnerStackTrace = exception.InnerException.StackTrace;
            }
        }
    }
}
