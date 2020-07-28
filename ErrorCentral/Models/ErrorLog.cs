using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorCentral.Models
{

    public class ErrorLog: IErrorLog
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("ocurred_at")]
        public DateTime? OcurredAt { get; set; }

        [Column("http_status_code")]
        [Required]
        public int HttpStatusCode { get; set; }

        [Column("url_path")]
        [Required]
        public string UrlPath { get; set; }

        [Column("remote_ip_host")]
        [Required]
        public string RemoteIpHost { get; set; }

        [Column("message")]
        [Required]
        public string Message { get; set; }

        [Column("user_id")]
        [Required]
        public int UserId { get; set; }

    }
}
