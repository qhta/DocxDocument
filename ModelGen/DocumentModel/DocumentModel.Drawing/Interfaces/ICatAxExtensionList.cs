namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public interface ICatAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ICatAxExtension>? CatAxExtensions { get ; set; }
  
}
