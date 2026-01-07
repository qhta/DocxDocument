namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public interface Surface3DChartExtension: Extension
{
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}