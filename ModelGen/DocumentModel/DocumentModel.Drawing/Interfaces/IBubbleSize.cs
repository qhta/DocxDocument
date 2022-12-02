namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public interface IBubbleSize // : DocumentModel.Drawing.INumberDataSourceType
{
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
}
