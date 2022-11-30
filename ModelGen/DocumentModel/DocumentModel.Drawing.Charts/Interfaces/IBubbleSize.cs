namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public interface IBubbleSize // : DocumentModel.Drawing.Charts.INumberDataSourceType
{
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberLiteral? NumberLiteral { get ; set; }
  
}
