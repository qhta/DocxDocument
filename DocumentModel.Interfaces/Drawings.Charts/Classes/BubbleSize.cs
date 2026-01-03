namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleSize Class.
/// </summary>
public interface BubbleSize: IModelElement
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}