using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public ICollection<Rider> Riders { get; set; }
    }
}
