namespace StringBuilding;

internal static class Generator
{
  public static void Generate()
  {
    foreach (var generator in (Func<int, string>[])[
      GenerateStringConcatenationTestCode,
      GenerateStringInterpolationTestCode,
      GenerateStringFormatTestCode
      ])
    {
      foreach (int count in (int[])[1, 10, 100, 1000])
      {
        Console.WriteLine($"{count} => {generator(count)},");
      }
      Console.WriteLine("_ => throw new NotSupportedException()");
      Console.WriteLine();
    }
  }

  private static string GenerateStringConcatenationTestCode(int i)
  {
    return string.Join("+", Enumerable.Range(1, i).Select(i => $"\"test\"+{nameof(Benchmarks.IV)}"));
  }

  private static string GenerateStringInterpolationTestCode(int i)
  {
    string template = string.Join("", Enumerable.Range(1, i).Select(i => $"test{{{nameof(Benchmarks.IV)}}}"));
    return $"$\"{template}\"";
  }

  private static string GenerateStringFormatTestCode(int i)
  {
    string template = string.Join("", Enumerable.Range(0, i).Select(i => $"test{{{i}}}"));
    string data = string.Join(",", Enumerable.Range(1, i).Select(_ => nameof(Benchmarks.IV)));
    return $"string.Format(\"{template}\",{data})";
  }
}