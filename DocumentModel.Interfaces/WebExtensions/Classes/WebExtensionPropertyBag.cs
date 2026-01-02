namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionPropertyBag Class.
/// </summary>
public class WebExtensionPropertyBag: ModelElement
{
  public Collection<WebExtensionProperty>? WebExtensionProperties { get; set; }
}