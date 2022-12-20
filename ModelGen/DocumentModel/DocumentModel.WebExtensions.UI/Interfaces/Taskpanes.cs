namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public partial interface Taskpanes
{
  public Collection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>? WebExtensionTaskpanes { get; set; }
  
}
