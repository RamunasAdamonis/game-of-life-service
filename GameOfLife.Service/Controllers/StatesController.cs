using GameOfLife.Service.Entities;
using GameOfLife.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameOfLife.Service.Controllers
{
    [Route("api/states")]
    public class StatesController : Controller
    {
        protected readonly IStateService _stateService;
        public StatesController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = new State
            {
                Grid = new int[10, 10]
            };

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Post");
        }
    }
}