namespace LambdaExpression
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Name = "Foo",
                },
                new Book
                {
                    Id= 2,
                    Name = "Bar",
                }
            };
        }
    }
}
