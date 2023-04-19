namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineChartSeries Class.
/// </summary>
public class LineChartSeries: ModelElement
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

  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<Trendline>? Trendlines { get; set; }

  public ErrorBars? ErrorBars { get; set; }

  public CategoryAxisData? CategoryAxisData { get; set; }

  public Values? Values { get; set; }

  public bool? Smooth { get; set; }

  public LineSerExtensionList? LineSerExtensionList { get; set; }
}