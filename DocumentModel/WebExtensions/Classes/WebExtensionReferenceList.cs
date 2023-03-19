namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionReferenceList Class.
/// </summary>
public class WebExtensionReferenceList: ModelElement
{
  public Collection<WebExtensionStoreReference>? WebExtensionStoreReferences { get; set; }
}