namespace ObjectSerialization.DTOs;

internal record MediumModel
{
  public Guid Id { get; set; }

  public bool Propery1 { get; set; }

  public DateTime Propery1UpdatedOn { get; set; }

  public int Propery2 { get; set; }

  public DateTime Propery2UpdatedOn { get; set; }

  public string? Propery3 { get; set; }

  public DateTime Propery3UpdatedOn { get; set; }

  public decimal Propery4 { get; set; }

  public DateTime Propery4UpdatedOn { get; set; }

  public string? Propery5 { get; set; }

  public DateTime Propery5UpdatedOn { get; set; }

  public IList<int>? Propery6 { get; set; }

  public DateTime Propery6UpdatedOn { get; set; }

  public DateTime CreatedOn { get; set; }
}