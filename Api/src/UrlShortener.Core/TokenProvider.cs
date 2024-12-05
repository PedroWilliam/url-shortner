namespace UrlShortener.Core;

public class TokenProvider
{
    private long _token = 0;
    private TokenRange? _tokenRange;

    public void AssignRange(long start, long end)
    {
        AssignRange(new TokenRange(start, end));
    }

    public void AssignRange(TokenRange tokenRange)
    {
        _tokenRange = tokenRange;
        _token = _tokenRange.Start;
    }

    public long GetToken()
    {
        return _token++;
    }
}
