namespace DocumentModel.Drawing.Charts;

public interface IPlus // : DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }
  
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
