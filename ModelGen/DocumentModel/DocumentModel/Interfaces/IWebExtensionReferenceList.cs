namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public interface IWebExtensionReferenceList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IWebExtensionStoreReference>? WebExtensionStoreReferences { get ; set; }
  
}
