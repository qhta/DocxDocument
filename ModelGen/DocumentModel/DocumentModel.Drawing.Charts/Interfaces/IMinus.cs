namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Minus.
/// </summary>
public interface IMinus // : DocumentModel.Drawing.Charts.INumberDataSourceType
{
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberLiteral? NumberLiteral { get ; set; }
  
}
