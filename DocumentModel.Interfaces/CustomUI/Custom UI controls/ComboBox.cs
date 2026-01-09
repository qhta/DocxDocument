namespace DocumentModel;

/// <summary>
/// Represents a combo box control that combines text input with a dropdown list of selectable items, supporting dynamic content, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a combo box control that allows users to either type text directly or select from a predefined list of options. Unlike a simple dropdown, the combo box provides an editable text field, making it suitable for scenarios where users need flexibility to enter custom values or select from suggestions. The control supports both static and dynamic content generation, customizable appearance with images and labels, text length constraints, and change notifications. It can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ComboBox : CustomUIControl, BuiltInControl, BoxContent, GroupContent, TaggedObject
{
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
  /// String representation of the combo box size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Invalidate dropdown content when the dropdown is closed.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  /// Enable interaction with the combo box.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Custom image identifier for the combo box icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the combo box icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic combo box image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Maximum number of characters that can be entered in the text field.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  /// Callback for dynamic text value of the combo box.
  /// </summary>
  public string? GetText { get; set; }

  /// <summary>
  /// Callback executed when the combo box text changes.
  /// </summary>
  public string? OnChange { get; set; }

  /// <summary>
  /// Screentip text for the combo box.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the combo box.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label text for the combo box.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the combo box in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the combo box.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the combo box label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the combo box image in the UI.
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
}