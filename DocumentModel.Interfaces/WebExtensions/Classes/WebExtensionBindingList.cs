namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionBindingList Class.
/// </summary>
public interface WebExtensionBindingList: IModelElement
{
  public Collection<WebExtensionBinding>? WebExtensionBindings { get; set; }
}