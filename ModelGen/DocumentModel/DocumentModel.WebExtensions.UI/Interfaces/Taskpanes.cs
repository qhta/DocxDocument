namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public partial interface Taskpanes
{
  /// <summary>
  /// Gets the WebExTaskpanesPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WebExTaskpanesPart? WebExTaskpanesPart { get; set; }
  
  public Collection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>? WebExtensionTaskpanes { get; set; }
  
}
