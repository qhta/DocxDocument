namespace DocumentModel.Drawing;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public interface IYValues // : DocumentModel.Drawing.INumberDataSourceType
{
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
}
