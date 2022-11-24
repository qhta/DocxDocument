namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public interface IBubbleChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public Index? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public IOrder? Order { get ; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  public InvertIfNegative? InvertIfNegative { get ; set; }
  
}
