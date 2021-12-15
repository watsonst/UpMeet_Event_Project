using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UpMeetAPI.Models;

namespace UpMeetAPI.Data
{
    public class UpMeetAPIContext : DbContext
    {
        public UpMeetAPIContext (DbContextOptions<UpMeetAPIContext> options)
            : base(options)
        {
        }

        public DbSet<UpMeetAPI.Models.Events> Events { get; set; }

        public DbSet<UpMeetAPI.Models.Favorites> Favorites { get; set; }
    }
}
