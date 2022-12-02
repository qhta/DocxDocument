namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public interface IDLblExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDLblExtension>? DLblExtensions { get ; set; }
  
}
