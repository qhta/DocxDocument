namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExtensionBindingList Class.
/// </summary>
public class WebExtensionBindingList: ModelElement
{
  public Collection<WebExtensionBinding>? WebExtensionBindings { get; set; }
}