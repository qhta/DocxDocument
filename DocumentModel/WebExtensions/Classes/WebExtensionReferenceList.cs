namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExtensionReferenceList Class.
/// </summary>
public class WebExtensionReferenceList: ModelElement
{
  public Collection<WebExtensionStoreReference>? WebExtensionStoreReferences { get; set; }
}