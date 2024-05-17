using DotNetGraphqlAPIUsingHotChocolate.Models;

namespace DotNetGraphqlAPIUsingHotChocolate.Queries
{
    public class ChapterQueries
    {
        public Chapter GetChapter() =>
       new Chapter
       {
           Id = 1,
           Description = "C# in depth.",
           Name = "Chapter 1"
       };

        public IEnumerable<Chapter> GetChapters() => new List<Chapter>() {
            new Chapter
       {
           Id = 1,
           Description = "C# in depth.",
           Name = "Chapter 1"
       },
           new Chapter
       {
           Id = 2,
           Description = "C# in depth.",
           Name = "Chapter 2"
       }
        };
    }
}
