namespace DocumentModel.Drawings;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public interface XValues // : DocumentModel.Drawings.AxisDataSourceType
{
  public MultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  public NumberReference? NumberReference { get ; set; }
  
  public NumberLiteral? NumberLiteral { get ; set; }
  
  public StringReference? StringReference { get ; set; }
  
  public StringLiteral? StringLiteral { get ; set; }
  
}
