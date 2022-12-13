namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public interface Surface3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
