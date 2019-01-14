namespace GMM.Data
{
    public class Catering
    {
        public int Id { get; set; }
        public int BoekingId { get; set; }
        public bool AfterShow { get; set; }
        public bool Special { get; set; }
        public bool TakeAwayFood { get; set; }
        public int Chauffeurs { get; set; }

        public Boeking Boeking { get; set; }
    }
}
