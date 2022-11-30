namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtensionList Class.
/// </summary>
public interface ISlideMasterExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ISlideMasterExtension>? SlideMasterExtensions { get ; set; }
  
}
