namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public interface Surface3DChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}