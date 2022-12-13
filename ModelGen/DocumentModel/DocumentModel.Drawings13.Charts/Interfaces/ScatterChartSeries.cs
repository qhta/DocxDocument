namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public interface ScatterChartSeries
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
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.DataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.Trendline>? Trendlines { get ; set; }
  
  public DocumentModel.Drawings.Charts.ErrorBars? ErrorBars { get ; set; }
  
  public DocumentModel.Drawings.Charts.XValues? XValues { get ; set; }
  
  public DocumentModel.Drawings.Charts.YValues? YValues { get ; set; }
  
  public Boolean? Smooth { get ; set; }
  
  public DocumentModel.Drawings.Charts.ScatterSerExtensionList? ScatterSerExtensionList { get ; set; }
  
}
