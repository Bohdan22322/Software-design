using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class Authenticator
{
    private static readonly object _lock = new object();
    private static Authenticator _instance;

    public string Username { get; private set; }

    // Приватний конструктор
    private Authenticator()
    {
        Username = "DefaultUser";
        Console.WriteLine("Authenticator instance created.");
    }

    public static Authenticator GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
            }
        }
        return _instance;
    }

    public void Login(string username)
    {
        Username = username;
        Console.WriteLine($"User '{username}' logged in.");
    }
}

