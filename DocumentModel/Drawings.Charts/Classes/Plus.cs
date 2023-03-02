namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Plus.
/// </summary>
public record Plus
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}