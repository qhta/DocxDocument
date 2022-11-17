namespace DocumentModel.Office2013.Drawing.Chart;

public interface IPieChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IIndex? Index { get ; set; }

  public IOrder? Order { get ; set; }

  public ISeriesText? SeriesText { get ; set; }

  public IChartShapeProperties? ChartShapeProperties { get ; set; }

  public IPictureOptions? PictureOptions { get ; set; }

  public DocumentModel.Drawing.Charts.IExplosion? Explosion { get ; set; }

}
