using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorCentral.Models
{
    interface IErrorLog
    {
        
        public DateTime? OcurredAt { get; }
        public int HttpStatusCode { get; }
        public string UrlPath { get; }
        public string RemoteIpHost { get; }
        public string Message { get; }
        public int UserId { get; }

    }
}
