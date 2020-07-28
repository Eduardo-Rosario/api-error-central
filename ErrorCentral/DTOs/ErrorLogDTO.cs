using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorCentral.DTOs
{
    public class ErrorLogDTO
    {
        
        public DateTime OcurredAt { get; set; }
        
        [Required]
        public int HttpStatusCode { get; set; }
        
        [Required]
        public string UrlPath { get; set; }
        
        [Required]
        public string RemoteIpHost { get; set; }
        
        [Required]
        public string Message { get; set; }

    }
}
