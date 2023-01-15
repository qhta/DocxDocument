namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D Surface Charts.
/// </summary>
public class Surface3DChart
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public Boolean? Wireframe { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<SurfaceChartSeries>? SurfaceChartSerieses { get; set; }

  public BandFormats? BandFormats { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
}