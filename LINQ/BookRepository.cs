namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
        {
            new Book
            {
                Name = "Moby Dick",
                Price = 123.44m,
            },
            new Book
            {
                Name = "Data Structures",
                Price = 34.22m,
            },
            new Book
            {
                Name = "The Great Gatsby",
                Price = 56.75m,
            },
            new Book
            {
                Name = "Introduction to Algorithms",
                Price = 89.99m,
            },
            new Book
            {
                Name = "To Kill a Mockingbird",
                Price = 45.50m,
            },
        };
        }
    }
}
