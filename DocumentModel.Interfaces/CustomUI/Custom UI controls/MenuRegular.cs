namespace DocumentModel;

/// <summary>
/// Represents a regular menu control that displays a dropdown list of commands within other menus or controls, supporting streamlined appearance, hierarchical organization, and dynamic integration for use in button groups and constrained ribbon contexts.
/// </summary>
/// <remarks>
/// This interface defines a streamlined menu control suitable for use within button groups, other menus, and constrained ribbon contexts. Unlike the standard <see cref="Menu"/> control which has additional sizing options, MenuRegular provides a simplified menu implementation optimized for nested menu scenarios. It presents a hierarchical collection of commands and controls including buttons, checkboxes, galleries, toggle buttons, separators, split buttons, and nested menus. The control supports customizable appearance with images, labels, tooltips, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface MenuRegular : CustomUIControl, BuiltInControl, TaggedObject, 
  DescriptionControl, EnableControl, VisibleControl, 
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ContextMenuContent, MenuContent, GroupBoxContent
{
  /// <summary>
  /// Size of items within the menu.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  /// Regular button control that executes an action when clicked.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Checkbox control for boolean selection.
  /// </summary>
  public CheckBox? CheckBox { get; set; }

  /// <summary>
  /// Regular gallery control that displays a collection of selectable items.
  /// </summary>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  /// Regular toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  /// Separator for visual division between menu items.
  /// </summary>
  public MenuSeparator? MenuSeparator { get; set; }

  /// <summary>
  /// Regular split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  /// Nested regular menu control for hierarchical menu organization.
  /// </summary>
  public MenuRegular? ChildMenuRegular { get; set; }

  /// <summary>
  /// Dynamic regular menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }
}