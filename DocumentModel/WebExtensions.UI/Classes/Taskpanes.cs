namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the Taskpanes Class.
/// </summary>
public record Taskpanes
{
  public Collection<WebExtensionTaskpane>? WebExtensionTaskpanes { get; set; }
}