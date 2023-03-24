namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public class SurfaceChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}