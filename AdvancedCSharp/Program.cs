using Delegates;
using EventsAndDelegates;
using ExtensionMethods;
using Generics;
using LambdaExpression;
namespace AdvancedCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics
            var numbers = new GenericList<int>();
            numbers.Add(1);

            var dictionary = new GenericDictionary<int, string>();
            dictionary.Add(12, "Stuff");


            var wordUtility = new Utitlities<string>();
            wordUtility.Max("word1", "word2");

            // Delegates
            var photoProcessor = new PhotoProcessor();
            Action<Photo> filter = PhotoFilter.AdjustBrightness;
            filter += PhotoFilter.AdjustContrast;
            filter += RemoveRedEyeFilter;

            photoProcessor.Process("path.png", filter);

            // Lambda Expression 
            var books = BookRepository.GetBooks();
            var filteredBooks = books.FindAll(book => book.Name == "Bar");

            // Events and Delegates

            Video video = new() { Title = "Advance C Sharp" };
            VideoEncoder encoder = new();
            MailService mailService = new();
            encoder.AddSubsciber((object? source, VideoEncoderEventArgs e) => { Console.WriteLine("Random Envent Subscriber doing something"); });
            encoder.AddSubsciber(mailService.OnVideoEncoded);
            encoder.Encode(video);

            //ExtensionMethods Methods

            string post = "This is a random post";

            Console.WriteLine(post.Shorten(3));

            // Language Integrated Query
            var books2 = new LINQ.BookRepository().GetBooks();
            var cheapBooks = books2
                .Where(book => book.Price < 80)
                .Select(b => b.Name);
            foreach (var book in cheapBooks)
            {
                
            }


            // Nullable 

            DateTime? datetime = new DateTime();
            Console.WriteLine(datetime?.Hour);

            // Dynamic Code 


        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Removeing Red Eye");
        }
    }
}
