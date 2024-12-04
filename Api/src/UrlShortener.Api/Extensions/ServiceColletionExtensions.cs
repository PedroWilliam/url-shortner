using UrlShortener.Core;
using UrlShortener.Core.Urls;
using UrlShortener.Core.Urls.Add;

namespace UrlShortener.Api.Extensions;

public static class ServiceColletionExtensions
{
    public static IServiceCollection AddUrlFeature(this IServiceCollection services)
    {
        services.AddScoped<AddUrlHandler>();
        services.AddSingleton<TokenProvider>(_ =>
        {
            var tokenProvider = new TokenProvider();
            tokenProvider.AssignRange(1, 1000);
            return tokenProvider;
        });
        services.AddScoped<ShortUrlGenerator>();

        services.AddSingleton<IUrlDataStore, InMemoryUrlDataStore>();

        return services;
    }
}

public class InMemoryUrlDataStore : Dictionary<string, ShortnedUrl>, IUrlDataStore
{
    public Task AddAsync(ShortnedUrl shortned, CancellationToken cancellationToken)
    {
        Add(shortned.ShortUrl, shortned);
        return Task.CompletedTask;
    }
}
