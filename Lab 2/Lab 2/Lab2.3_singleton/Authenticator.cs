public sealed class Authenticator
{
    private static readonly Lazy<Authenticator> instance = new(() => new Authenticator());

    public static Authenticator Instance => instance.Value;

    private Authenticator() {}

    public void Authenticate(string user, string password)
    {
        Console.WriteLine($"Authenticating {user}");
    }
}
