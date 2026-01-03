namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionReferenceList Class.
/// </summary>
public interface WebExtensionReferenceList: IModelElement
{
  public Collection<WebExtensionStoreReference>? WebExtensionStoreReferences { get; set; }
}