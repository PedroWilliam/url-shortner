using UrlShortener.Core;
using UrlShortener.Core.Urls.Add;

namespace UrlShortener.Api.Core.Tests;

public class AddUrlScenarios
{
    private readonly AddUrlHandler _handler;

    public AddUrlScenarios()
    {
        var tokenProvider = new TokenProvider();
        tokenProvider.AssignRange(1, 5);
        var shortUrlGenerator = new ShortUrlGenerator(tokenProvider);
        _handler = new AddUrlHandler(shortUrlGenerator);
    }

    [Fact]
    private async Task Should_return_shortned_url()
    {
        var request = CreateAddUrlRequest();

        var response = await _handler.HandleAsync(request, default);

        response.ShortUrl.Should().NotBeEmpty();
        response.ShortUrl.Should().Be("1");
    }

    private static AddUrlRequest CreateAddUrlRequest()
    {
        return new AddUrlRequest(new Uri("https://dometrain.com"));
    }
}
