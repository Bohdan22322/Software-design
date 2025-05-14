class Program
{
    static void Main(string[] args)
    {
        // Task 1: Factory Method
        SubscriptionFactory factory = new WebSite();
        var subscription = factory.CreateSubscription("Premium");
        Console.WriteLine($"Subscription: {subscription.GetType().Name}, Fee: {subscription.MonthlyFee}");

        // Task 2: Abstract Factory
        IBrandFactory brandFactory = new IProneFactory();
        Console.WriteLine($"Device: {brandFactory.CreateLaptop().GetDeviceType()}");

        // Task 3: Singleton
        var auth = Authenticator.Instance;
        auth.Authenticate("admin", "1234");

        // Task 4: Prototype
        var parentVirus = new Virus { Name = "Alpha", Species = "Corona", Weight = 1.2, Age = 2 };
        parentVirus.Children.Add(new Virus { Name = "Beta", Species = "Corona", Weight = 0.8, Age = 1 });
        var cloned = parentVirus.Clone();
        Console.WriteLine($"Cloned Virus: {cloned.Name}, Children: {cloned.Children.Count}");

        // Task 5: Builder
        var director = new CharacterDirector();
        var hero = director.CreateHero(new HeroBuilder());
        Console.WriteLine($"Hero: {hero}");
    }
}
