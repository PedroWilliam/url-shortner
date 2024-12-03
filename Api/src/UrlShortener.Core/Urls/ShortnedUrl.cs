namespace UrlShortener.Core.Urls;

public class ShortnedUrl
{
    public ShortnedUrl(Uri longUrl, string shortUrl)
    {
        LongUrl = longUrl;
        ShortUrl = shortUrl;
    }

    public Uri LongUrl { get; }
    public string ShortUrl { get; }
}
