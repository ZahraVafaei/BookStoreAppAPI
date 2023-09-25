using BookStoreApp.API.Model.Author;

namespace BookStoreApp.API.Model.Book
{
    public class BookReadOnlyDto:BaseDto
    {
        public string? Title { get; set; }

        public int? Year { get; set; } 

        public decimal? Price { get; set; }

        public string AuthorName { get; set; }
    }
}
