namespace DocumentModel.WebExtensions.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Taskpanes Class.
/// </summary>
public class Taskpanes: ModelElement
{
  public Collection<WebExtensionTaskpane>? WebExtensionTaskpanes { get; set; }
}