using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ErrorCentral.Services
{
    interface ILoggerHttpClient
    {
        public Task<HttpClient> GetClient();
    }
}
