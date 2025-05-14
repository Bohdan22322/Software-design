public class PremiumSubscription : ISubscription
{
    public double MonthlyFee => 12.99;
    public int MinPeriod => 1;
    public string[] Channels => new string[] { "Movies", "Sports", "International" };
}
