namespace DocumentModel;

/// <summary>
///   Represents a collection of context menus that define right-click menu options for Office UI customization.
/// </summary>
/// <remarks>
///   This interface defines a container for custom context menus
///   that can be displayed when users right-click on specific UI elements or document areas in Office applications.
///   Context menus provide contextual actions and commands relevant to the selected element or current context,
///   enhancing user productivity by offering quick access to frequently used operations. The collection enables
///   multiple context menu definitions to coexist, each potentially associated with different UI elements,
///   document types, or application contexts. Custom context menus can supplement or replace default Office
///   context menus, allowing add-ins to integrate seamlessly with the native user experience. Each context
///   menu in the collection can contain buttons, toggles, galleries, separators, and other controls organized
///   to provide intuitive access to custom functionality.
/// </remarks>
public interface ContextMenus : IElementCollection<ContextMenu>
{
}