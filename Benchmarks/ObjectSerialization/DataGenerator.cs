namespace ObjectSerialization;

internal static class DataGenerator
{
  private static Random _random = new();

  public static Guid RandomGuid => Guid.NewGuid();
  public static bool RandomBool => 0 == _random.Next(2) % 2;
  public static int RandomInt => _random.Next(100);
  public static decimal RandomDecimal => new decimal(_random.NextDouble() * 100);
  public static string RandomString => RandomGuid.ToString().Replace("-", "");
  public static DateTime RandomDateTime => DateTime.UtcNow
    .AddMilliseconds(_random.Next(2000) - 1000)
    .AddSeconds(_random.Next(120) - 60)
    .AddMinutes(_random.Next(120) - 60)
    .AddHours(_random.Next(48) - 24)
    .AddDays(_random.Next(730) - 365);
  public static IList<int> RandomIntList(int count) => Enumerable.Range(0, count).Select(_ => _random.Next(100)).ToList();
}