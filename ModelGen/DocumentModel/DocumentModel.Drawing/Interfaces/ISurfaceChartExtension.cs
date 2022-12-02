namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public interface ISurfaceChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
