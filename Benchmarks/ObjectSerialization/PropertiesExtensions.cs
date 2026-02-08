using System.Reflection;

namespace ObjectSerialization;

internal static class PropertiesExtensions
{
  public static (string Name, object? Value)[] GetPublicPropertiesWithValues<T>(this T obj)
    where T : notnull =>
    obj
      .GetType()
      .GetPropertiesInternal()
      .Select(pi => (pi.Name, pi.GetValue(obj)))
      .ToArray();

  public static string[] GetPublicProperties(this Type obj) =>
    obj
      .GetPropertiesInternal()
      .Select(pi => pi.Name)
      .ToArray();

  public static PropertyInfo[] GetPropertiesInternal(this Type obj) =>
    obj.GetProperties(BindingFlags.Public | BindingFlags.Instance);
}