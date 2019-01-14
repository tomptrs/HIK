namespace GMM.Data
{
    public class Leden
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }
        public int FunctieId { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }

        public Functie Functie { get; set; }
    }
}
