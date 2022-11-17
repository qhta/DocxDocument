namespace DocumentModel.Office2013.Drawing.Chart;

public interface ISurfaceChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IIndex? Index { get ; set; }

  public IOrder? Order { get ; set; }

  public ISeriesText? SeriesText { get ; set; }

  public IChartShapeProperties? ChartShapeProperties { get ; set; }

  public IPictureOptions? PictureOptions { get ; set; }

  public ICategoryAxisData? CategoryAxisData { get ; set; }

  public DocumentModel.Drawing.Charts.IValues? Values { get ; set; }

  public DocumentModel.Drawing.Charts.IBubble3D? Bubble3D { get ; set; }

  public ISurfaceSerExtensionList? SurfaceSerExtensionList { get ; set; }

}
