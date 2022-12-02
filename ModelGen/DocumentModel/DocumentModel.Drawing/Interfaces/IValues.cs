namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Values Class.
/// </summary>
public interface IValues // : DocumentModel.Drawing.INumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
