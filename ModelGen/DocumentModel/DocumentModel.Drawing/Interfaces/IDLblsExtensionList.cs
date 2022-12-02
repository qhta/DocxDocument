namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public interface IDLblsExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDLblsExtension>? DLblsExtensions { get ; set; }
  
}
