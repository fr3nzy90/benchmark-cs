namespace StringBuilding;

internal static class CodeGenerator
{
  private const string _indent = "  ";
  private const int _maxLineLength = 140;

  public static void Generate()
  {
    foreach (var generator in (Func<int, int, string>[])[
      GenerateStringConcatenationTestCode,
      GenerateStringInterpolationTestCode,
      GenerateSplitStringInterpolationTestCode,
      GenerateStringFormatTestCode,
      GenerateStringJoinTestCode
      ])
    {
      foreach (int count in (int[])[1, 10, 100, 1000])
      {
        Console.WriteLine($"{count} => {generator(count, $"{count} => ".Length)},");
      }
      Console.WriteLine("_ => throw new NotSupportedException()");
      Console.WriteLine();
    }
  }

  private static string GenerateStringConcatenationTestCode(int count, int initialOffset)
  {
    if (count < 1)
    {
      throw new ArgumentOutOfRangeException(nameof(count));
    }

    string result = string.Empty;
    string line = string.Empty;
    int lineIdx = 1;
    int itemIdx = 1;

    Action<string> addToLine = (string str) =>
    {
      if (line.Length + str.Length >= (_maxLineLength - 3 * _indent.Length - (1 == lineIdx ? initialOffset : _indent.Length)) - 1)
      {
        result += $"{line}{Environment.NewLine}";
        line = $"{_indent}{str}";
        ++lineIdx;
      }
      else
      {
        line += str;
      }
    };

    Enumerable
      .Range(1, count)
      .SelectMany(_ => (string[])["\"test\"", nameof(Benchmarks.IV)])
      .ToList()
      .ForEach(str => addToLine(1 < itemIdx++ ? $" + {str}" : str));

    return result + line;
  }

  private static string GenerateStringInterpolationTestCode(int count, int _)
  {
    if (count < 1)
    {
      throw new ArgumentOutOfRangeException(nameof(count));
    }

    string template = string.Join("", Enumerable.Range(1, count).Select(i => $"test{{{nameof(Benchmarks.IV)}}}"));
    return $"$\"{template}\"";
  }

  private static string GenerateSplitStringInterpolationTestCode(int count, int initialOffset)
  {
    if (count < 1)
    {
      throw new ArgumentOutOfRangeException(nameof(count));
    }

    string result = string.Empty;
    string line = "$\"";
    int lineIdx = 1;

    Action<string> addToLine = (string str) =>
    {
      if (line.Length + str.Length >= (_maxLineLength - 3 * _indent.Length - (1 == lineIdx ? initialOffset : _indent.Length)) - 2)
      {
        result += $"{line}\"{Environment.NewLine}";
        line = $"{_indent}+ $\"{str}";
        ++lineIdx;
      }
      else
      {
        line += str;
      }
    };

    Enumerable
      .Range(1, count)
      .Select(_ => $"test{{{nameof(Benchmarks.IV)}}}")
      .ToList()
      .ForEach(addToLine);

    return result + line + "\"";
  }

  private static string GenerateStringFormatTestCode(int count, int initialOffset)
  {
    if (count < 1)
    {
      throw new ArgumentOutOfRangeException(nameof(count));
    }

    string template = string.Join("", Enumerable.Range(0, count).Select(i => $"test{{{i}}}"));
    string result = string.Empty;
    string line = $"string.Format(\"{template}\"";
    int lineIdx = 1;

    Action<string> addToLine = (string str) =>
    {
      if (line.Length + str.Length >= (_maxLineLength - 3 * _indent.Length - (1 == lineIdx ? initialOffset : _indent.Length)) - 1)
      {
        result += $"{line}{Environment.NewLine}";
        line = $"{_indent}{str}";
        ++lineIdx;
      }
      else
      {
        line += str;
      }
    };

    Enumerable
      .Range(1, count)
      .Select(_ => $", {nameof(Benchmarks.IV)}")
      .ToList()
      .ForEach(addToLine);

    addToLine(")");

    return result + line;
  }

  private static string GenerateStringJoinTestCode(int count, int initialOffset)
  {
    if (count < 1)
    {
      throw new ArgumentOutOfRangeException(nameof(count));
    }

    string result = string.Empty;
    string line = $"string.Join(\"\"";
    int lineIdx = 1;

    Action<string> addToLine = (string str) =>
    {
      if (line.Length + str.Length >= (_maxLineLength - 3 * _indent.Length - (1 == lineIdx ? initialOffset : _indent.Length)) - 1)
      {
        result += $"{line}{Environment.NewLine}";
        line = $"{_indent}{str}";
        ++lineIdx;
      }
      else
      {
        line += str;
      }
    };

    Enumerable
      .Range(1, count)
      .SelectMany(_ => (string[])["\"test\"", nameof(Benchmarks.IV)])
      .Select(str => $", {str}")
      .ToList()
      .ForEach(addToLine);

    addToLine(")");

    return result + line;
  }
}