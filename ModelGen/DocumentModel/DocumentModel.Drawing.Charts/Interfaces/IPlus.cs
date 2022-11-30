namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Plus.
/// </summary>
public interface IPlus // : DocumentModel.Drawing.Charts.INumberDataSourceType
{
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberLiteral? NumberLiteral { get ; set; }
  
}
