namespace ObjectSerialization.DTOs;

internal record SmallModel
{
  public Guid Id { get; set; }

  public bool Propery1 { get; set; }

  public DateTime Propery1UpdatedOn { get; set; }

  public string? Propery2 { get; set; }

  public DateTime Propery2UpdatedOn { get; set; }

  public DateTime CreatedOn { get; set; }
}