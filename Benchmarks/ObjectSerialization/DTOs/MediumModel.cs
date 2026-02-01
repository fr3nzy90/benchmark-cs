namespace ObjectSerialization.DTOs;

internal record MediumModel
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

  public DateTime CreatedOn { get; init; } = DataGenerator.RandomDateTime;
}