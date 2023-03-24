namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExtensionPropertyBag Class.
/// </summary>
public class WebExtensionPropertyBag: ModelElement
{
  public Collection<WebExtensionProperty>? WebExtensionProperties { get; set; }
}