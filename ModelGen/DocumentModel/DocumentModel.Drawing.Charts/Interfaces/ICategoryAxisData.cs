namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public interface ICategoryAxisData // : DocumentModel.Drawing.Charts.IAxisDataSourceType
{
  public DocumentModel.Drawing.Charts.IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberLiteral? NumberLiteral { get ; set; }
  
  public DocumentModel.Drawing.Charts.IStringReference? StringReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.IStringLiteral? StringLiteral { get ; set; }
  
}
