using WeAreCars.Core.Services;

namespace WeAreCars.Tests;

public sealed class AuthenticationServiceTests
{
    [Fact]
    public void IsValid_AcceptsConfiguredPasswordForStaffUsername()
    {
        var service = new AuthenticationService("configured-password");

        Assert.True(service.IsConfigured);
        Assert.True(service.IsValid("sta001", "configured-password"));
    }

    [Theory]
    [InlineData("other-user", "configured-password")]
    [InlineData("sta001", "incorrect-password")]
    public void IsValid_RejectsIncorrectCredentials(string username, string password)
    {
        var service = new AuthenticationService("configured-password");

        Assert.False(service.IsValid(username, password));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void IsValid_RejectsCredentialsWhenPasswordIsNotConfigured(string? configuredPassword)
    {
        var service = new AuthenticationService(configuredPassword);

        Assert.False(service.IsConfigured);
        Assert.False(service.IsValid("sta001", "any-password"));
    }
}
