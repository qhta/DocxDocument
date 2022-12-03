namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public interface BubbleSize // : DocumentModel.Drawings.NumberDataSourceType
{
  public NumberReference? NumberReference { get ; set; }
  
  public NumberLiteral? NumberLiteral { get ; set; }
  
}
