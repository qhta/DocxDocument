namespace DocumentModel.Drawing.Charts;

public interface ISeriesText // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IStringReference? StringReference { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumericValue? NumericValue { get ; set; }
  
}
