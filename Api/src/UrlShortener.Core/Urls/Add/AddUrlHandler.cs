namespace UrlShortener.Core.Urls.Add;

public class AddUrlHandler
{
    private readonly ShortUrlGenerator _shortUrlGenerator;
    private readonly IUrlDataStore _urlDataStore;

    public AddUrlHandler(ShortUrlGenerator shortUrlGenerator, IUrlDataStore urlDataStore)
    {
        _shortUrlGenerator = shortUrlGenerator;
        _urlDataStore = urlDataStore;
    }

    public async Task<AddUrlResponse> HandleAsync(AddUrlRequest request, CancellationToken cancellationToken)
    {
        var shortned = new ShortnedUrl(request.LongUrl,
            _shortUrlGenerator.GenerateUniqueUrl(),
            request.CreatedBy);

        await _urlDataStore.AddAsync(shortned, cancellationToken);

        return new AddUrlResponse(request.LongUrl, shortned.ShortUrl);
    }
}