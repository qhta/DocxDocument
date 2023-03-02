namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleSize Class.
/// </summary>
public record BubbleSize
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}