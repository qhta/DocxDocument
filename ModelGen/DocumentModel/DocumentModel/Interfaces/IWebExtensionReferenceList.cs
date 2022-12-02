namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public interface IWebExtensionReferenceList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.IWebExtensionStoreReference>? WebExtensionStoreReferences { get ; set; }
  
}
