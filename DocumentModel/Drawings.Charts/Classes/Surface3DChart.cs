namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   3D Surface Charts.
/// </summary>
public class Surface3DChart: ModelElement
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public Boolean? Wireframe { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<SurfaceChartSeries>? SurfaceChartSeries { get; set; }

  public BandFormats? BandFormats { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
}