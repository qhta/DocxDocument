namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Surface Charts.
/// </summary>
public class SurfaceChart
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public Boolean? Wireframe { get; set; }

  public Collection<SurfaceChartSeries>? SurfaceChartSerieses { get; set; }

  public BandFormats? BandFormats { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
}