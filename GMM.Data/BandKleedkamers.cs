﻿using System;

namespace GMM.Data
{
    public class BandKleedkamers
    {
        public int Id { get; set; }
        public int BoekingId { get; set; }
        public int KleedkamerId { get; set; }
        public DateTime BeginUur { get; set; }
        public DateTime EindUur { get; set; }

        public Boeking Boeking { get; set; }
        public Kleedkamer Kleedkamer { get; set; }
    }
}
