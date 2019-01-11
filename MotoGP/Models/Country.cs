using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryID { get; set; }
        public string Name { get; set; }

     //   public ICollection<Race> Races { get; set; }
       // public ICollection<Rider> Riders { get; set; }
        //public ICollection<Ticket> Tickets { get; set; }
    }
}
