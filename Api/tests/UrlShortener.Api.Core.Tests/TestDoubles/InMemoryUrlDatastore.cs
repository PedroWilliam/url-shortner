using UrlShortener.Core.Urls;
using UrlShortener.Core.Urls.Add;

namespace UrlShortener.Api.Core.Tests.TestDoubles;

public class InMemoryUrlDatastore : Dictionary<string, ShortnedUrl>, IUrlDataStore
{
    public Task AddAsync(ShortnedUrl shortned, CancellationToken cancellationToken)
    {
        Add(shortned.ShortUrl, shortned);
        return Task.CompletedTask;
    }
}
