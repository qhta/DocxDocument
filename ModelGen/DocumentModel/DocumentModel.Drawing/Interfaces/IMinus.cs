namespace DocumentModel.Drawing;

/// <summary>
/// Minus.
/// </summary>
public interface IMinus // : DocumentModel.Drawing.INumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
