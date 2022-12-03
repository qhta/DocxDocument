namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public interface Surface3DChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
