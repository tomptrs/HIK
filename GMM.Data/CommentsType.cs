using System.Collections.Generic;

namespace GMM.Data
{
    public class CommentsType
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }

        public ICollection<Comments> Comments { get; set; }
    }
}
