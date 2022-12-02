namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public interface ISurfaceChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
