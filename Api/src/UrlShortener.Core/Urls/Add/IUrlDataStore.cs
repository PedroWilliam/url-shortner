namespace UrlShortener.Core.Urls.Add;

public interface IUrlDataStore
{
    Task AddAsync(ShortnedUrl shortned, CancellationToken cancellationToken);
}
