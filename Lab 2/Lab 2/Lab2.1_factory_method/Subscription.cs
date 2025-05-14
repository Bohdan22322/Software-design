public interface ISubscription
{
    double MonthlyFee { get; }
    int MinPeriod { get; }
    string[] Channels { get; }
}
