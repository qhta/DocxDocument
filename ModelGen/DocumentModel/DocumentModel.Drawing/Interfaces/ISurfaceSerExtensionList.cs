namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public interface ISurfaceSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISurfaceSerExtension>? SurfaceSerExtensions { get ; set; }
  
}
