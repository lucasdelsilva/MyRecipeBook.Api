using AutoMapper;
using CommonTestUtilities.IdEncryption;
using Microsoft.Extensions.Logging.Abstractions;
using MyRecipeBook.Application.Services.AutoMapper;

namespace CommonTestUtilities.Mapper;

public class MapperBuilder
{
    public static IMapper Build()
    {
        var idEncripter = IdEncripterBuilder.Build();

        var mapper = new MapperConfiguration(
            options => options.AddProfile(new AutoMapping(idEncripter)),
            NullLoggerFactory.Instance
        ).CreateMapper();

        return mapper;
    }
}