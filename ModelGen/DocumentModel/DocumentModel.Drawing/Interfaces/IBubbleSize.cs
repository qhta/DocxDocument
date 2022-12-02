namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public interface IBubbleSize // : DocumentModel.Drawing.INumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
