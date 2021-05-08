using CalendarAPI.Data;
using CalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPI.Repositories
{
    public class CalendarRepository : ICalendarRepository
    {
        private ApplicationDbContext _context;

        public CalendarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CalendarEvent> Create(CalendarEvent calendarEvent) 
        {
            _context.CalendarEvents.Add(calendarEvent);
            await _context.SaveChangesAsync();
            return calendarEvent;
        }
    }
}
