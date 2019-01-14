using System;
using System.Collections.Generic;
using System.Text;

namespace GMM.Data
{
    public class Speciaal
    {
        public int Id { get; set; }
        public int BoekingId { get; set; }
        public int HdWitGroot { get; set; }
        public int HdWitKlein { get; set; }
        public int HdZwartGroot { get; set; }
        public int HdZwartKlein { get; set; }
        public int Runner { get; set; }
        public string Arts { get; set; }
        public int Zuurstof { get; set; }
        public bool Kinesist { get; set; }
        public bool Vervoer { get; set; }

        public Boeking Boeking { get; set; }
    }
}
