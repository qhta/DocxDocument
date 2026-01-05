namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionPropertyBag Class.
/// </summary>
public interface WebExtensionPropertyBag:
{
  public Collection<WebExtensionProperty>? WebExtensionProperties { get; set; }
}