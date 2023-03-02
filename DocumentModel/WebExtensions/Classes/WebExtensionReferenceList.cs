namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionReferenceList Class.
/// </summary>
public record WebExtensionReferenceList
{
  public Collection<WebExtensionStoreReference>? WebExtensionStoreReferences { get; set; }
}