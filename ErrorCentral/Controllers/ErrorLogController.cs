using AutoMapper;
using ErrorCentral.DTOs;
using ErrorCentral.Models;
using ErrorCentral.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorCentral.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/errorlog")]
    public class ErrorLogController: ControllerBase
    {
        private IErrorLogService service;
        private IMapper mapper;

        public ErrorLogController(IErrorLogService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }


        [HttpGet]
        public ActionResult<ErrorLogDTO> Get(int? Id)
        {
            if (Id.HasValue)
                return Ok(
                    mapper.Map<ErrorLogDTO>(service.FindById(Id.Value)));
            else
                return NoContent();
        }
            
        public ActionResult<IEnumerable<ErrorLogDTO>> GetUserId(int? userId)
        {
            if (userId.HasValue)
            {
                return Ok(service.FindByUserId(userId.Value)
                    .Select(x => mapper.Map<ErrorLogDTO>(x))
                    .ToList());
            }
            else
                return NoContent();
        }

        [HttpGet("{statusCode}")]
        public ActionResult<IEnumerable<ErrorLogDTO>> GetStatusCode(int? statusCode)
        {
            if (statusCode.HasValue)
                return Ok(
                    mapper.Map<ErrorLogDTO>(service.FindByStatusCode(statusCode.Value)));
            else
                return NoContent();
        }

        [HttpPost]
        public ActionResult<ErrorLogDTO> Post([FromBody]ErrorLogDTO value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(mapper.Map<ErrorLogDTO>(service.Save(mapper.Map<ErrorLog>(value))));
        }
    }
}
