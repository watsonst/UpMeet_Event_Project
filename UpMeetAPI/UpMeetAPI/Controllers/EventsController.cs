using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UpMeetAPI.Data;
using UpMeetAPI.Models;

namespace UpMeetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : Controller
    {
        private readonly UpMeetAPIContext _context;

        public EventsController(UpMeetAPIContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("New")]
        public async Task<IActionResult> CreateEvent([Bind("Title,Date,Location,Organization,Details")] Events events)
        {

            events.Title = events.Title;
            events.Date = events.Date;
            events.Location = events.Location;
            events.Organization = events.Organization;
            events.Details = events.Details;

            await _context.AddAsync(events);
            await _context.SaveChangesAsync();

            var result = new OkObjectResult(events);
            return result;

        }


        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _context.Events.ToListAsync();

            var result = new OkObjectResult(events);
            return result;
        }


    }
}