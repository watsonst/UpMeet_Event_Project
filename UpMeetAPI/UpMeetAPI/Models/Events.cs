using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UpMeetAPI.Models
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Organization { get; set; }
        public string Details { get; set; }
    }
}

//EventID int Identity(1,1) primary key,
//Title nvarchar(255) not null,
//Date smalldatetime not null,
//Location nvarchar(255) not null,
//Organization nvarchar(255) not null,
//Details nvarchar(500) not null