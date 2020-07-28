using ErrorCentral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorCentral.Models;

namespace ErrorCentral.Services
{
    public interface IErrorLogService
    {
        public ErrorLog FindById(int errorLogId);
        public IList<ErrorLog> FindByUserId(int userId);
        public IList<ErrorLog> FindByStatusCode(int httpStatusCode);
        public ErrorLog Save(ErrorLog errorLog);
    }
}
