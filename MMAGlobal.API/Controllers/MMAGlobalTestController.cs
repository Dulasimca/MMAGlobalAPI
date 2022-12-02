using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MMAGlobal.Application.Commands;
using MMAGlobal.Application.Queries;
using MMAGlobal.Application.Responses;
using Microsoft.AspNetCore.Authorization;

namespace MMAGlobal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MMAGlobalTestController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MMAGlobalTestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet(nameof(Get))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<MMAGlobal.Core.Entity.MMAGlobalTestEntity>> Get()
        {
            return await _mediator.Send(new GetAllMMAGlobalTestQuery());
        }
 
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost(nameof(CreateEmployee))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MMAGlobalTestResponse>> CreateEmployee([FromBody] CreateMMAGlobalTestCommands command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
