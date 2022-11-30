namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public interface ISurfaceSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISurfaceSerExtension>? SurfaceSerExtensions { get ; set; }
  
}
