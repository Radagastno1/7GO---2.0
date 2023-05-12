using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Interfaces;
using Microsoft.Extensions.Logging;

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Usercontroller : ControllerBase
    {
        private readonly ILogger<Usercontroller> _logger;
        private readonly Iservice<CORE.Entities.User> _service;
        private readonly Challenge _challenge;

        public Usercontroller(
            ILogger<Usercontroller> logger,
            Iservice<CORE.Entities.User> service,
            Challenge challenge
        )
        {
            _challenge = challenge;
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateNewUser([FromBody] User user)
        {
            var createUser = await this._service.add(user);

            if (createUser == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        // [HttpGet]
<<<<<<< HEAD
        // public async Task<ActionResult<List<User>>> GetUsers()
=======
        // public async Task<ActionResult<List<User>>> GetUserTop10()
>>>>>>> 66cd00cec8b5455db45ca3cdf7fd351ad2299188
        // {
        //     var user = await this._service.Get().ToList();

        //     if (User == null)
        //     {
        //         return NotFound();
        //     }

<<<<<<< HEAD
        //     return Ok(user);
=======
        //     return Ok(user.TakeLast(10));
>>>>>>> 66cd00cec8b5455db45ca3cdf7fd351ad2299188
        // }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
        {
            var UpdateUser = await this._service.Put(user);
            if (UpdateUser == null)
            {
                return BadRequest();
            }

            return Ok();
        }

<<<<<<< HEAD
        [HttpDelete]
        public async Task<ActionResult<User>> DeleteUser(User user)
        {
            var deleteUser = await this._service.Delete(userId);
            if (deleteUser == null)
            {
                return NoContent();
            }
=======
        // [HttpDelete]
        // public async Task<ActionResult<User>> DeleteUser(int userId)
        // {
        //     var deleteUser = await this._service.Delete(userId);
        //     if (deleteUser == null)
        //     {
        //         return NoContent();
        //     }
>>>>>>> 66cd00cec8b5455db45ca3cdf7fd351ad2299188

        //     return Ok();
        // }
    }
}
