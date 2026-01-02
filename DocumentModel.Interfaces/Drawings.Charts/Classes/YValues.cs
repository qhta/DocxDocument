namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the YValues Class.
/// </summary>
public class YValues: ModelElement
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}