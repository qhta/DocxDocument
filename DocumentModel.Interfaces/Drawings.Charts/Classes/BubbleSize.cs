namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleSize Class.
/// </summary>
public class BubbleSize: ModelElement
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}