namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionPropertyBag Class.
/// </summary>
public interface IWebExtensionPropertyBag // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.WebExtension.IWebExtensionProperty>? WebExtensionProperties { get ; set; }
  
}
