namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public interface WebExtensionPropertyBag // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<WebExtensionProperty>? WebExtensionProperties { get ; set; }
  
}
