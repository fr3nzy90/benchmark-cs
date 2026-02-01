namespace ObjectSerialization.DTOs;

internal record LargeModel
{
  public Guid Id { get; init; } = DataGenerator.RandomGuid;

  public bool Propery1 { get; init; } = DataGenerator.RandomBool;

  public DateTime Propery1UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public int Propery2 { get; init; } = DataGenerator.RandomInt;

  public DateTime Propery2UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery3 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery3UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public decimal Propery4 { get; init; } = DataGenerator.RandomDecimal;

  public DateTime Propery4UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery5 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery5UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public IList<int> Propery6 { get; init; } = DataGenerator.RandomIntList(5);

  public DateTime Propery6UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public bool Propery7 { get; init; } = DataGenerator.RandomBool;

  public DateTime Propery7UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public int Propery8 { get; init; } = DataGenerator.RandomInt;

  public DateTime Propery8UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery9 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery9UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public decimal Propery10 { get; init; } = DataGenerator.RandomDecimal;

  public DateTime Propery10UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery11 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery11UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public IList<int> Propery12 { get; init; } = DataGenerator.RandomIntList(5);

  public DateTime Propery12UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public bool Propery13 { get; init; } = DataGenerator.RandomBool;

  public DateTime Propery13UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public int Propery14 { get; init; } = DataGenerator.RandomInt;

  public DateTime Propery14UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery15 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery15UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public decimal Propery16 { get; init; } = DataGenerator.RandomDecimal;

  public DateTime Propery16UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery17 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery17UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public IList<int> Propery18 { get; init; } = DataGenerator.RandomIntList(5);

  public DateTime Propery18UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public DateTime CreatedOn { get; init; } = DataGenerator.RandomDateTime;
}