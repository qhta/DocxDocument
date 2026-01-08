namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a surface chart, including wireframe, series, band formats, axis identifiers, and extension list.
/// </summary>
public interface SurfaceChart
{
  /// <summary>
  ///   Indicates whether the chart is rendered as a wireframe.
  /// </summary>
  public bool? Wireframe { get; set; }

  /// <summary>
  ///   Series displayed in the surface chart.
  /// </summary>
  public SurfaceChartSeriesList SurfaceChartSeries { get; set; }

  /// <summary>
  ///   Band formats configuration for the chart.
  /// </summary>
  public BandFormats? BandFormats { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
}