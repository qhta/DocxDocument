namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a 3D surface chart, including wireframe, color variation, series, band formats, axis identifiers, and extension list.
/// </summary>
public class Surface3DChart : ModelElement<DXDC.Surface3DChart>
{
  /// <summary>
  ///   Indicates whether the chart is rendered as a wireframe.
  /// </summary>
  public bool? Wireframe { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the 3D surface chart.
  /// </summary>
  public SurfaceChartSeriesList? SurfaceChartSeries { get; set; }

  /// <summary>
  ///   Band formats configuration for the chart.
  /// </summary>
  public BandFormats? BandFormats { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
}