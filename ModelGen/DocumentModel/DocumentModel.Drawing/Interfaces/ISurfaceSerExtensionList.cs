namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public interface ISurfaceSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISurfaceSerExtension>? SurfaceSerExtensions { get ; set; }
  
}
