public class DomesticSubscription : ISubscription
{
    public double MonthlyFee => 5.99;
    public int MinPeriod => 1;
    public string[] Channels => new string[] { "News", "Local", "Kids" };
}
