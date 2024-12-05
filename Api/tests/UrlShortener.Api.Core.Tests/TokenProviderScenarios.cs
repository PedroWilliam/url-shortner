using UrlShortener.Core;

namespace UrlShortener.Api.Core.Tests;

public class TokenProviderScenarios
{
    [Fact]
    public void Should_get_the_token_from_start()
    {
        var provider = new TokenProvider();
        
        provider.AssignRange(5, 10);

        provider.GetToken().Should().Be(5);
    }

    [Fact]
    public void Should_increment_token_on_get()
    {
        var provider = new TokenProvider();

        provider.AssignRange(5, 10);
        provider.GetToken();

        provider.GetToken().Should().Be(6);
    }
}
