namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Values Class.
/// </summary>
public interface IValues // : DocumentModel.Drawing.INumberDataSourceType
{
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
}
