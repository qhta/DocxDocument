namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public interface IYValues // : DocumentModel.Drawing.Charts.INumberDataSourceType
{
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberLiteral? NumberLiteral { get ; set; }
  
}
