namespace BookStoreApp.API.Model.Author
{
    public class AuthorReadOnlyDto:BaseDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
