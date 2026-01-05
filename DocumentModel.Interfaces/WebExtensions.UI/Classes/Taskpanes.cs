namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the Taskpanes Class.
/// </summary>
public interface Taskpanes:
{
  public Collection<WebExtensionTaskpane>? WebExtensionTaskpanes { get; set; }
}