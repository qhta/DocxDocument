namespace DocumentModel.Drawing;

/// <summary>
/// Plus.
/// </summary>
public interface IPlus // : DocumentModel.Drawing.INumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
