namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public interface IWebExtensionReferenceList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.WebExtension.IWebExtensionStoreReference>? WebExtensionStoreReferences { get ; set; }
  
}
