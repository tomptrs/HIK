using System.Collections.Generic;

namespace GMM.Data
{
    public class ProductieEenheid
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }

        public ICollection<BandProductieEenheden> BandProductieEenheden { get; set; }
    }
}
