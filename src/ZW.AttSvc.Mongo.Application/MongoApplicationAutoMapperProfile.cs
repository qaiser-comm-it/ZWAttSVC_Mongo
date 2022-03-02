using AutoMapper;
using ZW.AttSvc.Mongo.Authors;

namespace ZW.AttSvc.Mongo;

public class MongoApplicationAutoMapperProfile : Profile
{
    public MongoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Author, AuthorDto>();
    }
}
