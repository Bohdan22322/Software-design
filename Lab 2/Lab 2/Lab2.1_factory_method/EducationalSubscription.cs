public class EducationalSubscription : ISubscription
{
    public double MonthlyFee => 3.99;
    public int MinPeriod => 3;
    public string[] Channels => new string[] { "Science", "Documentary", "History" };
}
