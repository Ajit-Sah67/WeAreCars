namespace WeAreCars.Core.Services;

/// <summary>Checks the configured staff login credentials.</summary>
public sealed class AuthenticationService
{
    private readonly string? configuredPassword;

    public AuthenticationService(string? configuredPassword)
    {
        this.configuredPassword = configuredPassword;
    }

    public bool IsConfigured => !string.IsNullOrWhiteSpace(configuredPassword);

    /// <summary>Returns whether the supplied values match the configured staff login.</summary>
    public bool IsValid(string username, string password) =>
        IsConfigured &&
        string.Equals(username, "sta001", StringComparison.Ordinal) &&
        string.Equals(password, configuredPassword, StringComparison.Ordinal);
}