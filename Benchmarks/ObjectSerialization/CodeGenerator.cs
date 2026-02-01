using ObjectSerialization.DTOs;

namespace ObjectSerialization;

internal static class CodeGenerator
{
  public static void Generate()
  {
    foreach (var generator in (Func<Type, string>[])[
      GenerateInterpolatedSerializationTestCode,
      GenerateSplitInterpolatedSerializationTestCode
      ])
    {
      foreach (Type type in (Type[])[typeof(SmallModel), typeof(MediumModel), typeof(LargeModel), typeof(EnormousModel)])
      {
        Console.WriteLine($"case nameof({type.Name}):");
        Console.WriteLine("{");
        Console.WriteLine($"{type.Name} obj = ({type.Name})_obj;");
        Console.WriteLine($"return {generator(type)};");
        Console.WriteLine("}");
      }
      Console.WriteLine("default:");
      Console.WriteLine("throw new NotSupportedException();");
      Console.WriteLine();
    }
  }

  private static string GenerateInterpolatedSerializationTestCode(Type type)
  {
    string template = string.Join(",", type.GetPublicProperties().Select(name => $"{{nameof({type.Name}.{name})}}={{obj.{name}}}"));
    return $"$\"{{{{{{nameof({type.Name})}}: {template}}}}}\"";
  }

  private static string GenerateSplitInterpolatedSerializationTestCode(Type type)
  {
    string result = "";
    string line = $"$\"{{{{{{nameof({type.Name})}}: ";

    Action<string> addToLine = (string str) =>
    {
      if (line.Length + str.Length > 120)
      {
        result += $"{line}\"\r\n";
        line = $"+ $\"{str}";
      }
      else
      {
        line += str;
      }
    };

    bool propertyAdded = false;
    type
      .GetPublicProperties()
      .Select(name => $"{{nameof({type.Name}.{name})}}={{obj.{name}}}")
      .ToList()
      .ForEach(str =>
      {
        addToLine(propertyAdded ? $",{str}" : str);
        propertyAdded = true;
      });

    addToLine("}}\"");

    return result + line;
  }
}