using CalendarAPI;
using CalendarAPI.Data;
using CalendarAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class CalendarEventTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private IServiceProvider _service;
        private ApplicationDbContext _context;

        public CalendarEventTest(WebApplicationFactory<Startup> factory)
        {
            _service = factory.Services.GetService<IServiceScopeFactory>().CreateScope().ServiceProvider;
            _context = _service.GetService<ApplicationDbContext>();
        }

        [Fact(DisplayName = "Create Event")]
        public async Task CreateEvent()
        {
            bool flag = false;

            CalendarEvent calendarEvent = new CalendarEvent
            {
                Title = "Test Event",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(5),
                Description = "Just another test event"
            };

            _context.CalendarEvents.Add(calendarEvent);

            try
            {
                await _context.SaveChangesAsync();
                flag = true;
            }
            catch (Exception e) 
            {
                //throw e
                flag = false;
            }

            flag.Should().BeTrue();
        }

        [Fact(DisplayName = "Update Event")]
        public async Task MyTestMethodAsync()
        {
            bool flag = false;

            CalendarEvent calendarEvent = new CalendarEvent
            {
                Id = 1,
                Title = "Updated Event",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(10),
                Description = "Updated Acvitiy"
            };

            _context.CalendarEvents.Update(calendarEvent);

            try
            {
                await _context.SaveChangesAsync();
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }

            flag.Should().BeTrue();
        }
    }
}
