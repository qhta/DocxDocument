namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public interface WebExtensionReferenceList
{
  public Collection<DocumentModel.WebExtensions.WebExtensionStoreReference>? WebExtensionStoreReferences { get ; set; }
  
}
