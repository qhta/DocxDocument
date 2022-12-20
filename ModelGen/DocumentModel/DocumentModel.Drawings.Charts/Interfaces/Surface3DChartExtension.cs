namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public partial interface Surface3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
  
}
