﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Taskly.Application.Auth.Commands.Register;
using Taskly.Application.Auth.Consts;
using Taskly.Application.Auth.Queries.GetUsers;
using Taskly.Application.Jwt;
using Taskly.Domain;

namespace Taskly.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/auth")]
    public class AuthenticationController : BaseController
    {
        [HttpPost("token")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Token([FromForm] GetJwtTokenRequest request)
        {
            var res = await Mediator.Send(request);

            return Ok(res);
        }

        [HttpPost("register")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<Guid>> RegisterNewUser([FromForm] RegisterNewUserRequest user)
        {
            var result = await Mediator.Send(user);

            return Ok(result);
        }

        [HttpGet("users")]
        [Authorize(Roles = RoleIdents.Admin)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetUsers()
        {
            var res = await Mediator.Send(new GetUsersRequest());
            return Ok(res);
        }

    }
}
