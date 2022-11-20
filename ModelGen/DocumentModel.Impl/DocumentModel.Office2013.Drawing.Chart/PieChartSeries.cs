namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the PieChartSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICategoryAxisData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieSerExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExplosion))]
public class PieChartSeries: IPieChartSeries
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public IOrder? Order
  {
    get;
    set;
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public ISeriesText? SeriesText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExplosion? Explosion
  {
    get;
    set;
  }
  
}
