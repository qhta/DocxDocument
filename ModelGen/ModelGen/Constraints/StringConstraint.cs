using Qhta.Xml;

namespace ModelGen;

public record StringConstraint : Constraint
{
  public long? MinLength { get; set; }

  public long? MaxLength { get; set; }

  public long? Length { get; set; }

  public string? Regex { get; set; }

  public XsdType? XsdType { get; set; }

}