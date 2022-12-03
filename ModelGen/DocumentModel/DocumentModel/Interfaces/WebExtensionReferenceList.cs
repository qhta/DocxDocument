namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public interface WebExtensionReferenceList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<WebExtensionStoreReference>? WebExtensionStoreReferences { get ; set; }
  
}
