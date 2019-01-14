namespace GMM.Data
{
    public class Logistiek
    {
        public int Id { get; set; }
        public int BoekingId { get; set; }
        public bool Verlengkabels { get; set; }
        public int V110 { get; set; }

        public Boeking Boeking { get; set; }
    }
}
