namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public class ScatterChartSeries3: ModelElement
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Order.
  /// </summary>
  public UInt32? Order { get; set; }

  /// <summary>
  ///   Series Text.
  /// </summary>
  public SeriesText? SeriesText { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Marker.
  /// </summary>
  public Marker? Marker { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<Trendline>? Trendlines { get; set; }

  public Collection<ErrorBars>? ErrorBars { get; set; }

  public XValues? XValues { get; set; }

  public YValues? YValues { get; set; }

  public Boolean? Smooth { get; set; }

  public ScatterSerExtensionList? ScatterSerExtensionList { get; set; }
}