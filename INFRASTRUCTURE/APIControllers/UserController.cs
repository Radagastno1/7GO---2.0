// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using CORE.Entities;
// using CORE.Interfaces;
// using Microsoft.Extensions.Logging;

// namespace INFRASTRUCTURE.APIControllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class Usercontroller : ControllerBase
//     {
//         private readonly ILogger<Usercontroller> _logger;
//         private readonly Iservice<CORE.Entities.User> _service;
//         private readonly Challenge _challenge;

//         public Usercontroller(
//             ILogger<Usercontroller> logger,
//             Iservice<CORE.Entities.User> service,
//             Challenge challenge
//         )
//         {
//             _challenge = challenge;
//             _logger = logger;
//             _service = service;
//         }

//         [HttpPost]
//         public async Task<ActionResult<User>> CreateNewUser([FromBody] User user)
//         {
//             var createUser = await this._service.add(user);

//             if (createUser == null)
//             {
//                 return BadRequest();
//             }

//             return Ok();
//         }

//         // [HttpGet]
//         // public async Task<ActionResult<List<User>>> GetUserTop10()
//         // {
//         //     var user = await this._service.Get().ToList();

//         //     if (User == null)
//         //     {
//         //         return NotFound();
//         //     }

//         //     return Ok(user.TakeLast(10));
//         // }

//         [HttpPut]
//         public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
//         {
//             var UpdateUser = await this._service.Put(user);
//             if (UpdateUser == null)
//             {
//                 return BadRequest();
//             }

//             return Ok();
//         }

//         // [HttpDelete]
//         // public async Task<ActionResult<User>> DeleteUser(int userId)
//         // {
//         //     var deleteUser = await this._service.Delete(userId);
//         //     if (deleteUser == null)
//         //     {
//         //         return NoContent();
//         //     }

//         //     return Ok();
//         // }
//     }
// }
