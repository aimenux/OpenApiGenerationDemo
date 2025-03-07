using System.Net;
using FluentAssertions;

namespace ControllerApi.Tests;

public class IntegrationTests
{
    [Theory]
    [InlineData("api/todos")]
    [InlineData("api/todos?category=sports")]
    [InlineData("api/todos?category=health")]
    public async Task Should_Get_Todos(string route)
    {
        // arrange
        await using var fixture = new IntegrationTestsFactory();
        var client = fixture.CreateClient();

        // act
        var response = await client.GetAsync(route);
        var responseBody = await response.Content.ReadAsStringAsync();

        // assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        responseBody.Should().NotBeNullOrWhiteSpace();
    }
}