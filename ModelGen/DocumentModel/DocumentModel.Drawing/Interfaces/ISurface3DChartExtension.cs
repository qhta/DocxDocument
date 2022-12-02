namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public interface ISurface3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
