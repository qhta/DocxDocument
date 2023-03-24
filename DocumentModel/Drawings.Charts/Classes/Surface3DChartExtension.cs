namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public class Surface3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}