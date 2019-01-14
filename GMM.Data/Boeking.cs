using System;
using System.Collections.Generic;
using System.Text;

namespace GMM.Data
{
    public class Boeking
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public DateTime Datum { get; set; }
        public DateTime BeginUur { get; set; }
        public DateTime EindUur { get; set; }
        public string Uren { get; set; }
        public int PodiumId { get; set; }
        public int TentId { get; set; }

        public Band Band { get; set; }
        public Podium Podium { get; set; }
        public Tent Tent { get; set; }

        public ICollection<BandKleedkamers> BandKleedkamers { get; set; }
        public ICollection<BandProductieEenheden> BandProductieEenheden { get; set; }
        public ICollection<Catering> CateringItems { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Logistiek> LogistiekItems { get; set; }
        public ICollection<Speciaal> SpeciaalItems { get; set; }
        public ICollection<Voorzieningen> VoorzieningenItems { get; set; }
    }
}
