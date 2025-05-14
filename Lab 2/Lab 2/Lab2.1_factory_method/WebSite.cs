public class WebSite : SubscriptionFactory
{
    public override ISubscription CreateSubscription(string type)
    {
        return type switch
        {
            "Domestic" => new DomesticSubscription(),
            "Educational" => new EducationalSubscription(),
            "Premium" => new PremiumSubscription(),
            _ => throw new ArgumentException("Unknown type")
        };
    }
}
