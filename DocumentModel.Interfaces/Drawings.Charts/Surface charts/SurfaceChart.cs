namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Surface Charts.
/// </summary>
public interface SurfaceChart
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public bool? Wireframe { get; set; }
  public SurfaceChartSeries SurfaceChartSeries { get; set; }
  public BandFormats? BandFormats { get; set; }
  public AxisIds AxisIds { get; set; }
  public SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
}