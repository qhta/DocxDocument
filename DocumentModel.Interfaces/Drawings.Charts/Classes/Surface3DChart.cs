namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D Surface Charts.
/// </summary>
public class Surface3DChart: ModelElement
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public bool? Wireframe { get; set; }
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public Collection<SurfaceChartSeries>? SurfaceChartSeries { get; set; }
  public BandFormats? BandFormats { get; set; }
  public Collection<UInt32>? AxisIds { get; set; }
  public Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
}