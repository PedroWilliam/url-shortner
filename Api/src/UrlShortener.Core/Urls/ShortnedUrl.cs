namespace UrlShortener.Core.Urls;

public class ShortnedUrl
{
    public ShortnedUrl(Uri longUrl, string shortUrl, string createdBy, DateTimeOffset createdOn)
    {
        LongUrl = longUrl;
        ShortUrl = shortUrl;
        CreatedBy = createdBy;
        CreatedOn = createdOn;
    }

    public Uri LongUrl { get; }
    public string ShortUrl { get; }
    public string CreatedBy { get; }
    public DateTimeOffset CreatedOn { get; }
}
