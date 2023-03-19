namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Plus.
/// </summary>
public class Plus: ModelElement
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}