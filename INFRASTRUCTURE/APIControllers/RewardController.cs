using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Interfaces;

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RewardController : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Iservice<CORE.Entities.Reward> _service;

        public RewardController(ILogger<Challangecontroller> logger, Iservice<CORE.Entities.Reward> service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Reward>> PostReward([FromBody] Reward reward)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var post = await this._service.add(reward);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Reward>>> GetAllRewards()
        {
            var rewardList = await this._service.Get();
            if (rewardList == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Reward>> GetRewardById(int id)
        {
            var reward = await this._service.GetById(id);
            if (reward == null)
            {
                return NotFound();
            }
            return Ok(reward);
        }
    }
}
