using ErrorCentral.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorCentral.Models;
using ErrorCentral.Services;

namespace ErrorCentral.Services
{
    public class ErrorLogService: IErrorLogService
    {
        public ErrorCentralContext _context;

        public ErrorLogService(ErrorCentralContext context)
        {
            _context = context;
        }
        
        public ErrorLog FindById(int errorLogId)
        {
            return _context.ErrorLogs.Find(errorLogId);
        }
        
        public IList<ErrorLog> FindByUserId(int userId)
        {
            return _context.ErrorLogs.Where(e => e.UserId == userId).ToList();
        }
        
        public IList<ErrorLog> FindByStatusCode(int httpStatusCode)
        {
            return _context.ErrorLogs.Where(e => e.HttpStatusCode == httpStatusCode).ToList();
        }
        
        
        public ErrorLog Save(ErrorLog errorLog)
        {
            var state = errorLog.Id == 0 ? EntityState.Added : EntityState.Modified;
            _context.Entry(errorLog).State = state;
            _context.SaveChanges();
            return errorLog;
        }
    }
}
