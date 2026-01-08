namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in an area chart, including values, formatting, and data point configuration.
/// </summary>
public interface AreaChartSeries
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  public uint? Index { get; set; }

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  public uint? Order { get; set; }

  /// <summary>
  ///   Series text or name.
  /// </summary>
  public SeriesText? SeriesText { get; set; }

  /// <summary>
  ///   Data points for the series.
  /// </summary>
  public Collection<DataPoint>? DataPoints { get; set; }

  /// <summary>
  ///   Data labels for the series.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Chart shape properties for the series.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  public AreaSerExtensionList? AreaSerExtensionList { get; set; }
}