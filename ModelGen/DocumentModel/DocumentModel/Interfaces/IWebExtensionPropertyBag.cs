namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public interface IWebExtensionPropertyBag // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.IWebExtensionProperty>? WebExtensionProperties { get ; set; }
  
}
