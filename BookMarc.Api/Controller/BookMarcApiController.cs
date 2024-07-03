using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMarc.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookMarc.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookMarcApiController : ControllerBase
    {
        private readonly IKafkaConsumerService _kafkaConsumerService;
        public BookMarcApiController(IKafkaConsumerService kafkaConsumerService)
        {
            _kafkaConsumerService = kafkaConsumerService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string tootId)
        {
            return Ok(_kafkaConsumerService.GetTootInformation(tootId));
        }

    }
}