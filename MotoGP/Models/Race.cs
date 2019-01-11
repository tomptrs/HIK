using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Models
{
    public class Race
    {
        public int RaceID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }

        [Display (Name="Race datum")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

      //  public Country Country { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
