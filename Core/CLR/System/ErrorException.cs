﻿using Bridge.CLR;

namespace System 
{
    [Ignore]
    [Name("Bridge.ErrorException")]
    public class ErrorException : Exception
    {
        public virtual Error Error
        {
            get
            {
                return null;
            }
        }

        public ErrorException() 
        {
        }
        
        public ErrorException(string message) : base(message)
        {
        }

        public ErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}