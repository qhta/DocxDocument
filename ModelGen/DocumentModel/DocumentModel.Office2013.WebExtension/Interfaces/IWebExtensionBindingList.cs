namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public interface IWebExtensionBindingList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.WebExtension.IWebExtensionBinding>? WebExtensionBindings { get ; set; }
  
}
