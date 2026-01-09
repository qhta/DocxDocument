namespace DocumentModel;

/// <summary>
/// Represents a group of buttons and controls within a ribbon group or menu, supporting compact arrangement, visual clustering, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a container that groups related buttons and controls together within the Office ribbon UI. Button groups allow multiple controls to be visually clustered, providing better organization and efficient use of ribbon space by displaying controls in a compact arrangement.
/// </remarks>
public interface ButtonGroup : CustomUIControl, BoxContent
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Show the button group in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  /// Regular button control within the button group.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Toggle button control that maintains an on/off state.
  /// </summary>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  /// Gallery control that displays a collection of selectable items.
  /// </summary>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  /// Menu control that displays a dropdown list of options.
  /// </summary>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  /// Dynamic menu control that generates menu items at runtime.
  /// </summary>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  /// <summary>
  /// Split button control that combines a default action with a dropdown menu.
  /// </summary>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  /// Separator for visual division between controls.
  /// </summary>
  public Separator? Separator { get; set; }
}