namespace DocumentModel;

/// <summary>
/// Represents a regular menu control that displays a dropdown list of commands within other menus or controls, supporting streamlined appearance, hierarchical organization, and dynamic integration for use in button groups and constrained ribbon contexts.
/// </summary>
/// <remarks>
/// This interface defines a streamlined menu control suitable for use within button groups, other menus, and constrained ribbon contexts. Unlike the standard <see cref="Menu"/> control which has additional sizing options, MenuRegular provides a simplified menu implementation optimized for nested menu scenarios. It presents a hierarchical collection of commands and controls including buttons, checkboxes, galleries, toggle buttons, separators, split buttons, and nested menus. The control supports customizable appearance with images, labels, tooltips, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface MenuRegular : CustomUIControl, BuiltInObject, TaggedObject, 
  DescriptionControl, EnableControl, VisibleControl, 
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  MenuRegularContentCollection,
  KeytipControl, ScreentipControl, SupertipControl,
  ContextMenuContent, MenuContent, MenuRegularContent, GroupBoxContent
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