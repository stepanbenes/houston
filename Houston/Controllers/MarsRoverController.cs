using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Houston.Controllers
{
    [Route("api/rover")]
	public class MarsRoverController : Controller
	{
        private MarsRoverHandler MarsRoverHandler { get; }

        public MarsRoverController(MarsRoverHandler marsRoverHandler)
        {
            MarsRoverHandler = marsRoverHandler;
        }

        [HttpGet("distance")]
        public async Task<IActionResult> MeasureDistanceToObstacle()
        {
            string socketId = MarsRoverHandler.GetConnectedRovers().Single(); // TODO: handle no connected rover; handle multiple connected rovers
            int distanceInCm = await MarsRoverHandler.InvokeClientMethodAsync<int>(socketId, "measure_distance", arguments: Array.Empty<object>());
            return Ok(distanceInCm);
        }
    }
}
