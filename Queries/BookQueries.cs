using DotNetGraphqlAPIUsingHotChocolate.Models;

namespace DotNetGraphqlAPIUsingHotChocolate.Queries
{
    public class BookQueries
    {
        public ChapterQueries Chapter { get; set; } = new ChapterQueries();
        public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };

        public IEnumerable<Book> GetBooks() => new List<Book>() {
            new Book
            {
                Title = "C# in depth.",
                Author = new Author
                {
                    Name = "Jon Skeet"
                }
            },
            new Book
            {
                Title = "C# in depth again.",
                Author = new Author
                {
                    Name = "Jon Skeet again"
                }
            }
        };

    }
}
