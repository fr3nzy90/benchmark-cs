namespace ObjectSerialization;

internal static class DataGenerator
{
  private static Random _random = new();

  public static void PopulateRandom<T>(this T obj)
    where T : notnull
  {
    obj
     .GetType()
     .GetPropertiesInternal()
     .ToList()
     .ForEach(property =>
     {
       if (typeof(Guid) == property.PropertyType)
       {
         property.SetValue(obj, RandomGuid);
       }
       else if (typeof(bool) == property.PropertyType)
       {
         property.SetValue(obj, RandomBool);
       }
       else if (typeof(int) == property.PropertyType)
       {
         property.SetValue(obj, RandomInt);
       }
       else if (typeof(decimal) == property.PropertyType)
       {
         property.SetValue(obj, RandomDecimal);
       }
       else if (typeof(string) == property.PropertyType)
       {
         property.SetValue(obj, RandomString);
       }
       else if (typeof(DateTime) == property.PropertyType)
       {
         property.SetValue(obj, RandomDateTime);
       }
       else if (property.PropertyType.IsGenericType && typeof(IList<>) == property.PropertyType.GetGenericTypeDefinition()
         && 1 == property.PropertyType.GetGenericArguments().Length
         && typeof(int) == property.PropertyType.GetGenericArguments().FirstOrDefault())
       {
         property.SetValue(obj, RandomIntList(5));
       }
       else
       {
         throw new NotSupportedException();
       }
     });
  }

  private static Guid RandomGuid => Guid.NewGuid();
  private static bool RandomBool => 0 == _random.Next(2) % 2;
  private static int RandomInt => _random.Next(100);
  private static decimal RandomDecimal => new decimal(_random.NextDouble() * 100);
  private static string RandomString => RandomGuid.ToString().Replace("-", "");
  private static DateTime RandomDateTime => DateTime.UtcNow + TimeSpan.FromSeconds(_random.NextDouble() * 7200 - 3600);
  private static IList<int> RandomIntList(int count) => Enumerable.Range(0, count).Select(_ => _random.Next(100)).ToList();
}