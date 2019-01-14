namespace GMM.Data
{
    public class Functie
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }

        public ICollection<Leden> Leden { get; set; }
    }
}
