namespace DocumentModel.Office2013.Drawing.Chart;

public interface IBubbleChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IIndex? Index { get ; set; }
  
  public IOrder? Order { get ; set; }
  
  public ISeriesText? SeriesText { get ; set; }
  
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public IPictureOptions? PictureOptions { get ; set; }
  
  public IInvertIfNegative? InvertIfNegative { get ; set; }
  
}
