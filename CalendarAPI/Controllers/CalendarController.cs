using CalendarAPI.Helpers;
using CalendarAPI.Models;
using CalendarAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : Controller
    {
        private ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test() 
        {
            return Ok("Hello world~");
        }

        [HttpPost("create-event")]
        public async Task<IActionResult> CreateEvent(CalendarEvent calendarEvent) 
        {
            Response<CalendarEvent> response = await _calendarService.CreateEventAsync(calendarEvent);

            if (!response.Success)
                return StatusCode(500);

            return Ok(response.Data);
        }
    }
}
