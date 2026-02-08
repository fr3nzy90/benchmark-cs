using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using ObjectSerialization.DTOs;
using System.Text;
using System.Text.Json;

namespace ObjectSerialization;

[SimpleJob(RuntimeMoniker.Net80), SimpleJob(RuntimeMoniker.Net10_0)]
[MemoryDiagnoser]
[SkewnessColumn, KurtosisColumn]
[JsonExporterAttribute.Full]
public class Benchmarks
{
  [Params(nameof(SmallModel), nameof(MediumModel), nameof(LargeModel), nameof(EnormousModel))]
  public string Model { get; set; } = default!;

  private object _obj = default!;
  private (string Name, object? Value)[] _properties = default!;

  [GlobalSetup]
  public void GlobalSetup()
  {
    _obj = Model switch
    {
      nameof(SmallModel) => new SmallModel(),
      nameof(MediumModel) => new MediumModel(),
      nameof(LargeModel) => new LargeModel(),
      nameof(EnormousModel) => new EnormousModel(),
      _ => throw new NotSupportedException()
    };
    _obj.PopulateRandom();
    _properties = _obj.GetPublicPropertiesWithValues();
  }

  [Benchmark]
  public string Json() =>
    Model switch
    {
      nameof(SmallModel) => JsonSerializer.Serialize((SmallModel)_obj),
      nameof(MediumModel) => JsonSerializer.Serialize((MediumModel)_obj),
      nameof(LargeModel) => JsonSerializer.Serialize((LargeModel)_obj),
      nameof(EnormousModel) => JsonSerializer.Serialize((EnormousModel)_obj),
      _ => throw new NotSupportedException()
    };

  [Benchmark]
  public string SplitStringInterpolation()
  {
    switch (Model)
    {
      case nameof(SmallModel):
        {
          SmallModel obj = (SmallModel)_obj;
          return $"{{{nameof(SmallModel)}: {nameof(SmallModel.Id)}={obj.Id},{nameof(SmallModel.Propery1)}={obj.Propery1}"
            + $",{nameof(SmallModel.Propery1UpdatedOn)}={obj.Propery1UpdatedOn},{nameof(SmallModel.Propery2)}={obj.Propery2}"
            + $",{nameof(SmallModel.Propery2UpdatedOn)}={obj.Propery2UpdatedOn},{nameof(SmallModel.CreatedOn)}={obj.CreatedOn}}}";
        }
      case nameof(MediumModel):
        {
          MediumModel obj = (MediumModel)_obj;
          return $"{{{nameof(MediumModel)}: {nameof(MediumModel.Id)}={obj.Id},{nameof(MediumModel.Propery1)}={obj.Propery1}"
            + $",{nameof(MediumModel.Propery1UpdatedOn)}={obj.Propery1UpdatedOn},{nameof(MediumModel.Propery2)}={obj.Propery2}"
            + $",{nameof(MediumModel.Propery2UpdatedOn)}={obj.Propery2UpdatedOn},{nameof(MediumModel.Propery3)}={obj.Propery3}"
            + $",{nameof(MediumModel.Propery3UpdatedOn)}={obj.Propery3UpdatedOn},{nameof(MediumModel.Propery4)}={obj.Propery4}"
            + $",{nameof(MediumModel.Propery4UpdatedOn)}={obj.Propery4UpdatedOn},{nameof(MediumModel.Propery5)}={obj.Propery5}"
            + $",{nameof(MediumModel.Propery5UpdatedOn)}={obj.Propery5UpdatedOn},{nameof(MediumModel.Propery6)}={obj.Propery6}"
            + $",{nameof(MediumModel.Propery6UpdatedOn)}={obj.Propery6UpdatedOn},{nameof(MediumModel.CreatedOn)}={obj.CreatedOn}}}";
        }
      case nameof(LargeModel):
        {
          LargeModel obj = (LargeModel)_obj;
          return $"{{{nameof(LargeModel)}: {nameof(LargeModel.Id)}={obj.Id},{nameof(LargeModel.Propery1)}={obj.Propery1}"
            + $",{nameof(LargeModel.Propery1UpdatedOn)}={obj.Propery1UpdatedOn},{nameof(LargeModel.Propery2)}={obj.Propery2}"
            + $",{nameof(LargeModel.Propery2UpdatedOn)}={obj.Propery2UpdatedOn},{nameof(LargeModel.Propery3)}={obj.Propery3}"
            + $",{nameof(LargeModel.Propery3UpdatedOn)}={obj.Propery3UpdatedOn},{nameof(LargeModel.Propery4)}={obj.Propery4}"
            + $",{nameof(LargeModel.Propery4UpdatedOn)}={obj.Propery4UpdatedOn},{nameof(LargeModel.Propery5)}={obj.Propery5}"
            + $",{nameof(LargeModel.Propery5UpdatedOn)}={obj.Propery5UpdatedOn},{nameof(LargeModel.Propery6)}={obj.Propery6}"
            + $",{nameof(LargeModel.Propery6UpdatedOn)}={obj.Propery6UpdatedOn},{nameof(LargeModel.Propery7)}={obj.Propery7}"
            + $",{nameof(LargeModel.Propery7UpdatedOn)}={obj.Propery7UpdatedOn},{nameof(LargeModel.Propery8)}={obj.Propery8}"
            + $",{nameof(LargeModel.Propery8UpdatedOn)}={obj.Propery8UpdatedOn},{nameof(LargeModel.Propery9)}={obj.Propery9}"
            + $",{nameof(LargeModel.Propery9UpdatedOn)}={obj.Propery9UpdatedOn},{nameof(LargeModel.Propery10)}={obj.Propery10}"
            + $",{nameof(LargeModel.Propery10UpdatedOn)}={obj.Propery10UpdatedOn},{nameof(LargeModel.Propery11)}={obj.Propery11}"
            + $",{nameof(LargeModel.Propery11UpdatedOn)}={obj.Propery11UpdatedOn},{nameof(LargeModel.Propery12)}={obj.Propery12}"
            + $",{nameof(LargeModel.Propery12UpdatedOn)}={obj.Propery12UpdatedOn},{nameof(LargeModel.Propery13)}={obj.Propery13}"
            + $",{nameof(LargeModel.Propery13UpdatedOn)}={obj.Propery13UpdatedOn},{nameof(LargeModel.Propery14)}={obj.Propery14}"
            + $",{nameof(LargeModel.Propery14UpdatedOn)}={obj.Propery14UpdatedOn},{nameof(LargeModel.Propery15)}={obj.Propery15}"
            + $",{nameof(LargeModel.Propery15UpdatedOn)}={obj.Propery15UpdatedOn},{nameof(LargeModel.Propery16)}={obj.Propery16}"
            + $",{nameof(LargeModel.Propery16UpdatedOn)}={obj.Propery16UpdatedOn},{nameof(LargeModel.Propery17)}={obj.Propery17}"
            + $",{nameof(LargeModel.Propery17UpdatedOn)}={obj.Propery17UpdatedOn},{nameof(LargeModel.Propery18)}={obj.Propery18}"
            + $",{nameof(LargeModel.Propery18UpdatedOn)}={obj.Propery18UpdatedOn},{nameof(LargeModel.CreatedOn)}={obj.CreatedOn}}}";
        }
      case nameof(EnormousModel):
        {
          EnormousModel obj = (EnormousModel)_obj;
          return $"{{{nameof(EnormousModel)}: {nameof(EnormousModel.Id)}={obj.Id},{nameof(EnormousModel.Propery1)}={obj.Propery1}"
            + $",{nameof(EnormousModel.Propery1UpdatedOn)}={obj.Propery1UpdatedOn},{nameof(EnormousModel.Propery2)}={obj.Propery2}"
            + $",{nameof(EnormousModel.Propery2UpdatedOn)}={obj.Propery2UpdatedOn},{nameof(EnormousModel.Propery3)}={obj.Propery3}"
            + $",{nameof(EnormousModel.Propery3UpdatedOn)}={obj.Propery3UpdatedOn},{nameof(EnormousModel.Propery4)}={obj.Propery4}"
            + $",{nameof(EnormousModel.Propery4UpdatedOn)}={obj.Propery4UpdatedOn},{nameof(EnormousModel.Propery5)}={obj.Propery5}"
            + $",{nameof(EnormousModel.Propery5UpdatedOn)}={obj.Propery5UpdatedOn},{nameof(EnormousModel.Propery6)}={obj.Propery6}"
            + $",{nameof(EnormousModel.Propery6UpdatedOn)}={obj.Propery6UpdatedOn},{nameof(EnormousModel.Propery7)}={obj.Propery7}"
            + $",{nameof(EnormousModel.Propery7UpdatedOn)}={obj.Propery7UpdatedOn},{nameof(EnormousModel.Propery8)}={obj.Propery8}"
            + $",{nameof(EnormousModel.Propery8UpdatedOn)}={obj.Propery8UpdatedOn},{nameof(EnormousModel.Propery9)}={obj.Propery9}"
            + $",{nameof(EnormousModel.Propery9UpdatedOn)}={obj.Propery9UpdatedOn},{nameof(EnormousModel.Propery10)}={obj.Propery10}"
            + $",{nameof(EnormousModel.Propery10UpdatedOn)}={obj.Propery10UpdatedOn},{nameof(EnormousModel.Propery11)}={obj.Propery11}"
            + $",{nameof(EnormousModel.Propery11UpdatedOn)}={obj.Propery11UpdatedOn},{nameof(EnormousModel.Propery12)}={obj.Propery12}"
            + $",{nameof(EnormousModel.Propery12UpdatedOn)}={obj.Propery12UpdatedOn},{nameof(EnormousModel.Propery13)}={obj.Propery13}"
            + $",{nameof(EnormousModel.Propery13UpdatedOn)}={obj.Propery13UpdatedOn},{nameof(EnormousModel.Propery14)}={obj.Propery14}"
            + $",{nameof(EnormousModel.Propery14UpdatedOn)}={obj.Propery14UpdatedOn},{nameof(EnormousModel.Propery15)}={obj.Propery15}"
            + $",{nameof(EnormousModel.Propery15UpdatedOn)}={obj.Propery15UpdatedOn},{nameof(EnormousModel.Propery16)}={obj.Propery16}"
            + $",{nameof(EnormousModel.Propery16UpdatedOn)}={obj.Propery16UpdatedOn},{nameof(EnormousModel.Propery17)}={obj.Propery17}"
            + $",{nameof(EnormousModel.Propery17UpdatedOn)}={obj.Propery17UpdatedOn},{nameof(EnormousModel.Propery18)}={obj.Propery18}"
            + $",{nameof(EnormousModel.Propery18UpdatedOn)}={obj.Propery18UpdatedOn},{nameof(EnormousModel.Propery19)}={obj.Propery19}"
            + $",{nameof(EnormousModel.Propery19UpdatedOn)}={obj.Propery19UpdatedOn},{nameof(EnormousModel.Propery20)}={obj.Propery20}"
            + $",{nameof(EnormousModel.Propery20UpdatedOn)}={obj.Propery20UpdatedOn},{nameof(EnormousModel.Propery21)}={obj.Propery21}"
            + $",{nameof(EnormousModel.Propery21UpdatedOn)}={obj.Propery21UpdatedOn},{nameof(EnormousModel.Propery22)}={obj.Propery22}"
            + $",{nameof(EnormousModel.Propery22UpdatedOn)}={obj.Propery22UpdatedOn},{nameof(EnormousModel.Propery23)}={obj.Propery23}"
            + $",{nameof(EnormousModel.Propery23UpdatedOn)}={obj.Propery23UpdatedOn},{nameof(EnormousModel.Propery24)}={obj.Propery24}"
            + $",{nameof(EnormousModel.Propery24UpdatedOn)}={obj.Propery24UpdatedOn},{nameof(EnormousModel.Propery25)}={obj.Propery25}"
            + $",{nameof(EnormousModel.Propery25UpdatedOn)}={obj.Propery25UpdatedOn},{nameof(EnormousModel.Propery26)}={obj.Propery26}"
            + $",{nameof(EnormousModel.Propery26UpdatedOn)}={obj.Propery26UpdatedOn},{nameof(EnormousModel.Propery27)}={obj.Propery27}"
            + $",{nameof(EnormousModel.Propery27UpdatedOn)}={obj.Propery27UpdatedOn},{nameof(EnormousModel.Propery28)}={obj.Propery28}"
            + $",{nameof(EnormousModel.Propery28UpdatedOn)}={obj.Propery28UpdatedOn},{nameof(EnormousModel.Propery29)}={obj.Propery29}"
            + $",{nameof(EnormousModel.Propery29UpdatedOn)}={obj.Propery29UpdatedOn},{nameof(EnormousModel.Propery30)}={obj.Propery30}"
            + $",{nameof(EnormousModel.Propery30UpdatedOn)}={obj.Propery30UpdatedOn},{nameof(EnormousModel.Propery31)}={obj.Propery31}"
            + $",{nameof(EnormousModel.Propery31UpdatedOn)}={obj.Propery31UpdatedOn},{nameof(EnormousModel.Propery32)}={obj.Propery32}"
            + $",{nameof(EnormousModel.Propery32UpdatedOn)}={obj.Propery32UpdatedOn},{nameof(EnormousModel.Propery33)}={obj.Propery33}"
            + $",{nameof(EnormousModel.Propery33UpdatedOn)}={obj.Propery33UpdatedOn},{nameof(EnormousModel.Propery34)}={obj.Propery34}"
            + $",{nameof(EnormousModel.Propery34UpdatedOn)}={obj.Propery34UpdatedOn},{nameof(EnormousModel.Propery35)}={obj.Propery35}"
            + $",{nameof(EnormousModel.Propery35UpdatedOn)}={obj.Propery35UpdatedOn},{nameof(EnormousModel.Propery36)}={obj.Propery36}"
            + $",{nameof(EnormousModel.Propery36UpdatedOn)}={obj.Propery36UpdatedOn},{nameof(EnormousModel.CreatedOn)}={obj.CreatedOn}}}";
        }
      default:
        throw new NotSupportedException();
    }
  }

  [Benchmark]
  public string StringJoinDynamic()
  {
    string result = $"{{{Model}";

    if (_properties.Length > 0)
    {
      result += $": {string.Join(",", _properties.Select(p => $"{p.Name}={p.Value}"))}";
    }

    return result + "}";
  }

  [Benchmark]
  public string StringBuilderWithAppends()
  {
    StringBuilder builder = new StringBuilder()
      .Append("{")
      .Append(Model);

    if (_properties.Length > 0)
    {
      builder.Append(": ");

      foreach ((string name, object? value) in _properties.SkipLast(1))
      {
        builder
          .Append(name)
          .Append("=")
          .Append(value)
          .Append(",");
      }

      {
        (string name, object? value) = _properties.Last();
        builder
          .Append(name)
          .Append("=")
          .Append(value);
      }
    }

    return builder
      .Append("}")
      .ToString();
  }

  [Benchmark]
  public string StringBuilderWithInterpolatedAppends()
  {
    StringBuilder builder = new StringBuilder()
      .Append($"{{{Model}");

    if (_properties.Length > 0)
    {
      builder.Append(": ");

      foreach ((string name, object? value) in _properties.SkipLast(1))
      {
        builder.Append($"{name}={value},");
      }

      {
        (string name, object? value) = _properties.Last();
        builder.Append($"{name}={value}");
      }
    }

    return builder
      .Append("}")
      .ToString();
  }

  [Benchmark]
  public string StringBuilderWithAppendsAndPresetCapacity()
  {
    StringBuilder builder = new StringBuilder(GetInitialCapacity())
      .Append("{")
      .Append(Model);

    if (_properties.Length > 0)
    {
      builder.Append(": ");

      foreach ((string name, object? value) in _properties.SkipLast(1))
      {
        builder
          .Append(name)
          .Append("=")
          .Append(value)
          .Append(",");
      }

      {
        (string name, object? value) = _properties.Last();
        builder
          .Append(name)
          .Append("=")
          .Append(value);
      }
    }

    return builder
      .Append("}")
      .ToString();
  }

  [Benchmark]
  public string StringBuilderWithInterpolatedAppendsAndPresetCapacity()
  {
    StringBuilder builder = new StringBuilder(GetInitialCapacity())
      .Append($"{{{Model}");

    if (_properties.Length > 0)
    {
      builder.Append(": ");

      foreach ((string name, object? value) in _properties.SkipLast(1))
      {
        builder.Append($"{name}={value},");
      }

      {
        (string name, object? value) = _properties.Last();
        builder.Append($"{name}={value}");
      }
    }

    return builder
      .Append("}")
      .ToString();
  }

  private int GetInitialCapacity()
  {
    int result = Model.Length + 3;

    foreach ((string name, object? value) in _properties)
    {
      result += name.Length + 2;
    }

    return result;
  }
}