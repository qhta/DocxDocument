namespace DocumentModel.Office2013.Drawing.Chart;

public interface IMarker // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ISymbol? Symbol { get ; set; }

  public ISize? Size { get ; set; }

  public IChartShapeProperties? ChartShapeProperties { get ; set; }

  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }

}
