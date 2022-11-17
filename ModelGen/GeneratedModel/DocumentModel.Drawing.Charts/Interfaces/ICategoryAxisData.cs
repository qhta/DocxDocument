namespace DocumentModel.Drawing.Charts;

public interface ICategoryAxisData // : DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType
{
  public IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
  public IStringReference? StringReference { get ; set; }
  
  public IStringLiteral? StringLiteral { get ; set; }
  
}
