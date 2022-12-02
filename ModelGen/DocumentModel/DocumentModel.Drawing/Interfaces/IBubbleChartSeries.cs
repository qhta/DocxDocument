namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public interface IBubbleChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order { get ; set; }
  
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
  public Boolean? InvertIfNegative { get ; set; }
  
  public Collection<IDataPoint>? DataPoints { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Collection<ITrendline>? Trendlines { get ; set; }
  
  public Collection<IErrorBars>? ErrorBarses { get ; set; }
  
  public IXValues? XValues { get ; set; }
  
  public IYValues? YValues { get ; set; }
  
  public IBubbleSize? BubbleSize { get ; set; }
  
  public Boolean? Bubble3D { get ; set; }
  
  public IBubbleSerExtensionList? BubbleSerExtensionList { get ; set; }
  
}
