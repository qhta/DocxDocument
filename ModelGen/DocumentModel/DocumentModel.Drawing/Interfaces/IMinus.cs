namespace DocumentModel.Drawing;

/// <summary>
/// Minus.
/// </summary>
public interface IMinus // : DocumentModel.Drawing.INumberDataSourceType
{
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
}
