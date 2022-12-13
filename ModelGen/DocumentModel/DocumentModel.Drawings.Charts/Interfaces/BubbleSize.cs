namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public interface BubbleSize
{
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get ; set; }
  
}
