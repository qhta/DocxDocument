namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public interface ICategoryAxisData // : DocumentModel.Drawing.IAxisDataSourceType
{
  public DocumentModel.Drawing.IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
  public DocumentModel.Drawing.IStringReference? StringReference { get ; set; }
  
  public DocumentModel.Drawing.IStringLiteral? StringLiteral { get ; set; }
  
}
