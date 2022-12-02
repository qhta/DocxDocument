namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public interface IScatterChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// Marker.
  /// </summary>
  public IMarker? Marker { get ; set; }
  
  public Collection<IDataPoint>? DataPoints { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Collection<ITrendline>? Trendlines { get ; set; }
  
  public Collection<IErrorBars>? ErrorBarses { get ; set; }
  
  public IXValues? XValues { get ; set; }
  
  public IYValues? YValues { get ; set; }
  
  public Boolean? Smooth { get ; set; }
  
  public IScatterSerExtensionList? ScatterSerExtensionList { get ; set; }
  
}
