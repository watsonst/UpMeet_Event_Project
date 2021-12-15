using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UpMeetAPI.Models
{
    public class Favorites
    {
        [Key]
        public int ID { get; set; }
        public int EventID { get; set;}
        public string UserID { get; set; }
    }
}

//ID int Identity(1,1) primary key,
//EventID int foreign key references Events(EventID),
//UserID int not null