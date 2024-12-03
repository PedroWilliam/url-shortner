namespace UrlShortener.Core.Urls;

public class ShortnedUrl
{
    public ShortnedUrl(Uri longUrl, string shortUrl, string createdBy)
    {
        LongUrl = longUrl;
        ShortUrl = shortUrl;
        CreatedBy = createdBy;
    }

    public Uri LongUrl { get; }
    public string ShortUrl { get; }
    public string CreatedBy { get; }
}
