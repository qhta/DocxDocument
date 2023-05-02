namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Surface Charts.
/// </summary>
public class SurfaceChart: ModelElement
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public bool? Wireframe { get; set; }

  public Collection<SurfaceChartSeries>? SurfaceChartSeries { get; set; }

  public BandFormats? BandFormats { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
}