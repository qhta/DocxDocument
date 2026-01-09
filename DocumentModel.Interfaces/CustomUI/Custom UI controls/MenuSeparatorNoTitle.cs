namespace DocumentModel;

/// <summary>
/// Represents a menu separator without a title for Office UI, supporting flexible positioning and organization of context menu items.
/// </summary>
/// <remarks>
/// This interface defines a menu separator control that provides visual division between menu items without a section label. It supports custom positioning using built-in or qualified IDs, and enables improved organization and readability of context menus and other Office UI containers.
/// </remarks>
public interface MenuSeparatorNoTitle: CustomUIControl, ContextMenuContent
{

}