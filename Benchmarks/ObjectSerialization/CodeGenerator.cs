using ObjectSerialization.DTOs;

namespace ObjectSerialization;

internal static class CodeGenerator
{
  private const string _indent = "  ";

  public static void Generate()
  {
    foreach (var generator in (Func<Type, string>[])[
      GenerateSplitInterpolatedSerializationTestCode
      ])
    {
      foreach (Type type in (Type[])[typeof(SmallModel), typeof(MediumModel), typeof(LargeModel), typeof(EnormousModel)])
      {
        Console.WriteLine($"case nameof({type.Name}):");
        Console.WriteLine("{");
        Console.WriteLine($"{_indent}{type.Name} obj = ({type.Name})_obj;");
        Console.WriteLine($"{_indent}return {generator(type)};");
        Console.WriteLine("}");
      }
      Console.WriteLine("default:");
      Console.WriteLine($"{_indent}throw new NotSupportedException();");
      Console.WriteLine();
    }

    foreach (var generator in (Func<Type, string>[])[
      GenerateJsonSerializationTestCode
      ])
    {
      foreach (Type type in (Type[])[typeof(SmallModel), typeof(MediumModel), typeof(LargeModel), typeof(EnormousModel)])
      {
        Console.WriteLine($"nameof({type.Name}) => {generator(type)},");
      }
      Console.WriteLine("_ => throw new NotSupportedException()");
      Console.WriteLine();
    }
  }

  private static string GenerateJsonSerializationTestCode(Type type) =>
    $"JsonSerializer.Serialize(({type.Name})_obj)";

  private static string GenerateSplitInterpolatedSerializationTestCode(Type type)
  {
    string result = "";
    string line = $"$\"{{{{{{nameof({type.Name})}}: ";
    int propertyIdx = 1;

    Action<string> addToLine = (string str) =>
    {
      if (line.Length + str.Length > 140)
      {
        result += $"{line}\"{Environment.NewLine}";
        line = $"{_indent}{_indent}+ $\"{str}";
      }
      else
      {
        line += str;
      }
    };

    type
      .GetPublicProperties()
      .Select(name => $"{{nameof({type.Name}.{name})}}={{obj.{name}}}")
      .ToList()
      .ForEach(str => addToLine(1 < propertyIdx++ ? $",{str}" : str));

    addToLine("}}\"");

    return result + line;
  }
}