using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Model.Author
{
    public class AuthorCreateDto:BaseDto
    {
       
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

    }
}
