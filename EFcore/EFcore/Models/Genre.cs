namespace EFcore.Models
{
    public class Genre
    {
        public Genre() => Books = new HashSet<Book>();
        public int GenreId { get; set; }
        public string Name { get; set; } = string.Empty;
        // navigation property
        public ICollection<Book> Books { get; set; }
    }
}
