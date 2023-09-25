using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Model.Author;
using BookStoreApp.API.Model.Book;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<Book,BookReadOnlyDto>()
                .ForMember(q=>q.AuthorName,d => d.MapFrom(map=>$"{map.Author.FirstName}{map.Author.LastName}"))
                .ReverseMap();
        }
    }
}
