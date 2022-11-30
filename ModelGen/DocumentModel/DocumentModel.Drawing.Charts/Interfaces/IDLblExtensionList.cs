namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public interface IDLblExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IDLblExtension>? DLblExtensions { get ; set; }
  
}
