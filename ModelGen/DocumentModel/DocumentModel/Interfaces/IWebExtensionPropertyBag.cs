namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public interface IWebExtensionPropertyBag // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IWebExtensionProperty>? WebExtensionProperties { get ; set; }
  
}
