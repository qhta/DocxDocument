namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionBindingList Class.
/// </summary>
public interface IWebExtensionBindingList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IWebExtensionBinding>? WebExtensionBindings { get ; set; }
  
}
