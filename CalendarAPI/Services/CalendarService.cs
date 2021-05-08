using CalendarAPI.Helpers;
using CalendarAPI.Models;
using CalendarAPI.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPI.Services
{
    public class CalendarService : ICalendarService
    {
        private ILogger<CalendarService> _logger;
        private ICalendarRepository _calendarRepository;

        public CalendarService(ILogger<CalendarService> logger, ICalendarRepository calendarRepository)
        {
            _logger = logger;
            _calendarRepository = calendarRepository;
        }

        public async Task<Response<CalendarEvent>> CreateEventAsync(CalendarEvent calendarEvent) 
        {
            if (calendarEvent is null)
                return null;

            try
            {
                await _calendarRepository.Create(calendarEvent);
                return Response.Ok(calendarEvent);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Response.Fail<CalendarEvent>(e.Message);
            }
        }
    }
}
