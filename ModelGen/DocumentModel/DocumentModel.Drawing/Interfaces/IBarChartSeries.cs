namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarChartSeries Class.
/// </summary>
public interface IBarChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// InvertIfNegative.
  /// </summary>
  public Boolean? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  public Collection<IDataPoint>? DataPoints { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Collection<ITrendline>? Trendlines { get ; set; }
  
  public IErrorBars? ErrorBars { get ; set; }
  
  public ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public IValues? Values { get ; set; }
  
  public ShapeKind? Shape { get ; set; }
  
  public IBarSerExtensionList? BarSerExtensionList { get ; set; }
  
}
