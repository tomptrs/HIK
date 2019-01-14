using System;
using System.Collections.Generic;
using System.Text;

namespace GMM.Data
{
    public class Voorzieningen
    {
        public int Id { get; set; }
        public int BoekingId { get; set; }
        public bool Wasserij { get; set; }
        public int BusStock { get; set; }
        public int CoolersBand { get; set; }
        public int CoolersGmm { get; set; }

        public Boeking Boeking { get; set; }
    }
}
