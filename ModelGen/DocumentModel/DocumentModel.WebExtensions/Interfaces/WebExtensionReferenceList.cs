namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionReferenceList Class.
/// </summary>
public partial interface WebExtensionReferenceList
{
  public Collection<DocumentModel.WebExtensions.WebExtensionStoreReference>? WebExtensionStoreReferences { get; set; }
  
}
