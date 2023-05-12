using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Services;
using Microsoft.Extensions.Logging;
using CORE.Interfaces;

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challangecontroller : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Iservice<CORE.Entities.Challenge> _service;
        private readonly User _user;

        public Challangecontroller(
            ILogger<Challangecontroller> logger,
            Iservice<CORE.Entities.Challenge> service,
            User user
        )
        {
            _logger = logger;
            _service = service;
            _user = user;
        }

        [HttpPost]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 400)]
        public async Task<ActionResult<Challenge>> CreateUserChallenge(
            [FromBody] Challenge challenge
        )
        {
            var createChallenge = await this._service.add(challenge);

            if (createChallenge == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 400)]
        public async Task<ActionResult<User>> UserChallenge([FromBody] User user)
        {
            var userChallenge = await this._service.add(user);

            if (userChallenge == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 400)]
        public async Task<ActionResult<List<Challenge>>> GetAllChallanges()
        {
            var challangeList = await this._service.Get();
            if (challangeList == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("{int:id}")]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 404)]
        public async Task<ActionResult<Challenge>> GetChallengeById(int id)
        {
            var result = await this._service.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
