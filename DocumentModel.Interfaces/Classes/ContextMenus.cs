namespace DocumentModel;

/// <summary>
///   Represents a collection of context menus that define right-click menu options.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and provides access to a collection
///   of <see cref="ContextMenu"/> items that can be displayed when users interact with
///   specific UI elements or document areas.
/// </remarks>
public interface ContextMenus : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of context menu items.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="ContextMenu"/> objects, or <c>null</c> if no context menus are defined.
  /// </value>
  public Collection<ContextMenu>? Items { get; set; }
}