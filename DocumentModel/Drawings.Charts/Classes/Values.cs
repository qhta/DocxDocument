namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Values Class.
/// </summary>
public class Values: ModelElement
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}