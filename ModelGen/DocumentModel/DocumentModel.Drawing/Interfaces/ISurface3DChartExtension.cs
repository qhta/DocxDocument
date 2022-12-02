namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public interface ISurface3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
