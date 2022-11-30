namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Values Class.
/// </summary>
public interface IValues // : DocumentModel.Drawing.Charts.INumberDataSourceType
{
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberLiteral? NumberLiteral { get ; set; }
  
}
