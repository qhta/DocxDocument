namespace DocumentModel;

/// <summary>
/// Represents a separator control that provides visual division between menu items, supporting section labeling and flexible positioning for improved menu organization.
/// </summary>
/// <remarks>
/// This interface defines a visual divider used to organize and separate groups of related items within menus. Menu separators can optionally display a title to label sections of the menu, providing better organization and improving usability by creating logical groupings of commands. Separators support positioning relative to other menu items and can have their title determined statically or dynamically through callbacks.
/// </remarks>
public interface MenuSeparator : CustomUIControl, TaggedObject, 
  TitleControl,
  MenuContent
{

}