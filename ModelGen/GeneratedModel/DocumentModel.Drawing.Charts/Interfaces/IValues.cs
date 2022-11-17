namespace DocumentModel.Drawing.Charts;

public interface IValues // : DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType
{
  public INumberReference? NumberReference { get ; set; }

  public INumberLiteral? NumberLiteral { get ; set; }

}
