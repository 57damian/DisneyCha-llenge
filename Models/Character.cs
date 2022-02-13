namespace DisneyChallenge.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }

        public int Age { get; set; }

        public int Wieght { get; set; }

        public string History { get; set; }

        public ICollection<Movie> movies { get; set; } = new List<Movie>();
    }
}
