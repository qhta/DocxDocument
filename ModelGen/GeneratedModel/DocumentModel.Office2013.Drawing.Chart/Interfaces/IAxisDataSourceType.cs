namespace DocumentModel.Office2013.Drawing.Chart;

public interface IAxisDataSourceType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IMultiLevelStringReference? MultiLevelStringReference { get ; set; }

  public INumberReference? NumberReference { get ; set; }

  public INumberLiteral? NumberLiteral { get ; set; }

  public IStringReference? StringReference { get ; set; }

  public IStringLiteral? StringLiteral { get ; set; }

}
