namespace DocumentModel.Office2013.Drawing.Chart;

public interface ILineChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IIndex? Index { get ; set; }
  
  public IOrder? Order { get ; set; }
  
  public ISeriesText? SeriesText { get ; set; }
  
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.IMarker? Marker { get ; set; }
  
  public IPictureOptions? PictureOptions { get ; set; }
  
}
