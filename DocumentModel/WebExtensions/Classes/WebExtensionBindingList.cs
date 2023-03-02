namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionBindingList Class.
/// </summary>
public record WebExtensionBindingList
{
  public Collection<WebExtensionBinding>? WebExtensionBindings { get; set; }
}