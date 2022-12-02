namespace DocumentModel.Drawing;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public interface IYValues // : DocumentModel.Drawing.INumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
