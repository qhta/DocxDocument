namespace DocumentModel;

/// <summary>
///   Represents a collection of context menus that define right-click menu options for Office UI customization.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a container for custom context menus
///   that can be displayed when users right-click on specific UI elements or document areas in Office applications.
///   Context menus provide contextual actions and commands relevant to the selected element or current context,
///   enhancing user productivity by offering quick access to frequently used operations. The collection enables
///   multiple context menu definitions to coexist, each potentially associated with different UI elements,
///   document types, or application contexts. Custom context menus can supplement or replace default Office
///   context menus, allowing add-ins to integrate seamlessly with the native user experience. Each context
///   menu in the collection can contain buttons, toggles, galleries, separators, and other controls organized
///   to provide intuitive access to custom functionality.
/// </remarks>
public interface ContextMenus : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of context menu definitions.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="ContextMenu"/> objects defining custom right-click menus,
  ///   or <c>null</c> if no context menus are defined.
  /// </value>
  /// <remarks>
  ///   Each <see cref="ContextMenu"/> in the collection defines a complete context menu with its associated
  ///   controls and trigger conditions. The collection enables add-ins to define multiple context menus
  ///   for different scenarios or UI elements within the same Office application. Context menus are identified
  ///   and triggered based on their configuration, allowing targeted customization of the user's right-click
  ///   experience in specific contexts or for specific document elements.
  /// </remarks>
  public Collection<ContextMenu>? Items { get; set; }
}