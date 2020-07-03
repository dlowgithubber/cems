using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CEMS.Core.Exceptions
{
    public class BusinessException : Exception
    {
        public string Type { get; set; }
        public BusinessException() { Type = "Generic Error"; }
        public BusinessException(string message) : base(message) { Type = "Generic Error"; }
        public BusinessException(string message, string type) : base(message) { Type = type; }
        public BusinessException(string message, string type, Exception inner) : base(message, inner) { Type = type; }
    }
}
