namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public interface ISurfaceChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISurfaceChartExtension>? SurfaceChartExtensions { get ; set; }
  
}
