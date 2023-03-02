namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionPropertyBag Class.
/// </summary>
public record WebExtensionPropertyBag
{
  public Collection<WebExtensionProperty>? WebExtensionProperties { get; set; }
}