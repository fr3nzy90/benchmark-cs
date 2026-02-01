namespace ObjectSerialization.DTOs;

internal record SmallModel
{
  public Guid Id { get; init; } = DataGenerator.RandomGuid;

  public bool Propery1 { get; init; } = DataGenerator.RandomBool;

  public DateTime Propery1UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public string Propery2 { get; init; } = DataGenerator.RandomString;

  public DateTime Propery2UpdatedOn { get; init; } = DataGenerator.RandomDateTime;

  public DateTime CreatedOn { get; init; } = DataGenerator.RandomDateTime;
}