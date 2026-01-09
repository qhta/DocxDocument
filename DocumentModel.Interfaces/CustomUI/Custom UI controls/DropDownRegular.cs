namespace DocumentModel;

/// <summary>
/// Represents a regular dropdown control that displays a list of selectable items, suitable for use within menus and button groups, supporting dynamic content, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a streamlined dropdown control optimized for use within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard dropdown control which may have additional sizing options, DropDownRegular provides a simplified dropdown implementation that maintains consistent dimensions appropriate for its context. The control allows users to select from a predefined list of options displayed in a dropdown menu. It supports both static and dynamic content generation, customizable appearance with images and labels for both the control and its items, selection tracking, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface DropDownRegular : BoxContentControl
{
  /// <summary>
  /// Callback executed when a dropdown item is selected.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Enable interaction with the dropdown.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Custom image identifier for the dropdown button icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the dropdown button icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic dropdown image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Show item images in the dropdown list.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  /// Callback for dynamic item count.
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  /// Callback for dynamic item label.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  /// Callback for dynamic item screentip.
  /// </summary>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  /// Callback for dynamic item supertip.
  /// </summary>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  /// Callback for dynamic item image.
  /// </summary>
  public string? GetItemImage { get; set; }

  /// <summary>
  /// Callback for dynamic item identifier.
  /// </summary>
  public string? GetItemID { get; set; }

  /// <summary>
  /// String representation of the dropdown size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Callback for dynamic selected item identifier.
  /// </summary>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  /// Callback for dynamic selected item index.
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  /// Show item labels in the dropdown list.
  /// </summary>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Built-in Office identifier for a dropdown control.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Screentip text for the dropdown.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the dropdown.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label text for the dropdown.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the dropdown in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the dropdown.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the dropdown label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the dropdown image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }

  /// <summary>
  /// Collection of static items displayed in the dropdown list.
  /// </summary>
  public SelectionItems? Items { get; set; }

  /// <summary>
  /// Collection of button controls that can be displayed in the dropdown.
  /// </summary>
  public ButtonRegulars? ButtonRegulars { get; set; }
}