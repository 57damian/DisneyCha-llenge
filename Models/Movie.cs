using System.ComponentModel.DataAnnotations;

namespace DisneyChallenge.Models

{
    public class Movie
    {
        public int Id { get; set; }
        [Required] [MaxLength (30)]
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }

        public int Score { get; set; }

        public Category Category { get; set; }

        public ICollection<Character> characters { get; set; } = new List<Character>();

        

    }
}
