namespace GMM.Data
{
    public class Comments
    {
        public int Id { get; set; }
        public int BoekingId { get; set; }
        public int TypeId { get; set; }
        public string Omschrijving { get; set; }

        public Boeking Boeking { get; set; }
        public CommentsType CommentType { get; set; }
    }
}
