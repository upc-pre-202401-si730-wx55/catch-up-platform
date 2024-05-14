using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Interfaces.Resources;

namespace CatchUpPlatform.API.News.Interfaces.Transform;

public static class CreateFavoriteSourceCommandFromResourceAssembler
{
    public static CreateFavoriteSourceCommand ToCommandFromResource(CreateFavoriteSourceResource resource)
    {
        return new CreateFavoriteSourceCommand(resource.NewsApiKey, resource.SourceId);
    }
}