namespace DocumentModel;

/// <summary>
/// Represents a menu control that displays a dropdown list of commands and controls in the ribbon interface, supporting hierarchical organization, customizable appearance, and dynamic integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a menu control that presents a hierarchical collection of commands when clicked. Menus can contain various child controls including buttons, checkboxes, galleries, toggle buttons, separators, split buttons, and nested menus. They support customizable appearance with images, labels, tooltips, sizing options, and can have their state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface Menu : CustomUIControl, BuiltInControl, TaggedObject, 
  EnableControl, DescriptionControl, VisibleControl, SizeControl,
  LabelledControl,
  ImagedControl, ShowImageControl,
  KeytipControl,
  BoxContent, GroupContent,
  MenuContentCollection
{

  /// <summary>
  /// Size of items within the menu.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

}