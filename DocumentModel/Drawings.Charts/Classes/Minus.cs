namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Minus.
/// </summary>
public class Minus: ModelElement
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}