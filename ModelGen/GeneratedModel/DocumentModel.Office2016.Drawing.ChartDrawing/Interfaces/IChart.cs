namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IChartTitle? ChartTitle { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IPlotArea? PlotArea { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.ILegend? Legend { get ; set; }

  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }

}
