namespace DocumentModel;

/// <summary>
/// Represents a customizable context menu (right-click menu) in Office applications, supporting dynamic content, context-aware commands, and advanced integration for Office UI extensibility.
/// </summary>
public interface ContextMenu : CollectionItem, BuiltInControl
{
  /// <summary>
  /// Reference to a built-in Office control to clone and add to the context menu.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  /// List of child controls contained in the context menu.
  /// </summary>
  public ContextMenuContentList Children { get; set; }
}