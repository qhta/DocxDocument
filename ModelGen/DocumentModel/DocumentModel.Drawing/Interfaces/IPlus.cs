namespace DocumentModel.Drawing;

/// <summary>
/// Plus.
/// </summary>
public interface IPlus // : DocumentModel.Drawing.INumberDataSourceType
{
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
}
