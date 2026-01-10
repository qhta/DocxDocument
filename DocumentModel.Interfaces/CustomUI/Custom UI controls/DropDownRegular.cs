namespace DocumentModel;

/// <summary>
/// Represents a regular dropdown control that displays a list of selectable items, suitable for use within menus and button groups, supporting dynamic content, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a streamlined dropdown control optimized for use within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard dropdown control which may have additional sizing options, DropDownRegular provides a simplified dropdown implementation that maintains consistent dimensions appropriate for its context. The control allows users to select from a predefined list of options displayed in a dropdown menu. It supports both static and dynamic content generation, customizable appearance with images and labels for both the control and its items, selection tracking, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface DropDownRegular : CustomUIControl, BuiltInObject, TaggedObject, 
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  EnableControl, VisibleControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ItemsControl, SelectedItemControl,
  SelectionItemCollection, 
  BoxContent, GroupContent
{
  /// <summary>
  /// Callback executed when a dropdown item is selected.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// String representation of the dropdown size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Show item labels in the dropdown list.
  /// </summary>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  /// Callback for dynamic item label visibility.
  /// </summary>
  public RegularButtonsCollection RegularButtons { get; set; }

}