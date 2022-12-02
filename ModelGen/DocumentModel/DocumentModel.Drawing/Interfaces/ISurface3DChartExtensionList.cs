namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public interface ISurface3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISurface3DChartExtension>? Surface3DChartExtensions { get ; set; }
  
}
