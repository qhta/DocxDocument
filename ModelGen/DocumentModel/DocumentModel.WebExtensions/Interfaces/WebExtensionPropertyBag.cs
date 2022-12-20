namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public partial interface WebExtensionPropertyBag
{
  public Collection<DocumentModel.WebExtensions.WebExtensionProperty>? WebExtensionProperties { get; set; }
  
}
