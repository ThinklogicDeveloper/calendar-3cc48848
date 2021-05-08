using CalendarAPI.Helpers;
using CalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPI.Services
{
    public interface ICalendarService
    {
        Task<Response<CalendarEvent>> CreateEventAsync(CalendarEvent calendarEvent);
    }
}
