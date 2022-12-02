namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public interface ICategoryAxisData // : DocumentModel.Drawing.IAxisDataSourceType
{
  public IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
  public IStringReference? StringReference { get ; set; }
  
  public IStringLiteral? StringLiteral { get ; set; }
  
}
