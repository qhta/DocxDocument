namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public interface IDLblsExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDLblsExtension>? DLblsExtensions { get ; set; }
  
}
