namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Minus.
/// </summary>
public record Minus
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}