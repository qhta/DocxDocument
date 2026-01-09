namespace DocumentModel;

/// <summary>
/// Represents a split button control in the Office ribbon interface that combines a primary action button with a dropdown menu of related options, supporting dynamic behavior, advanced positioning, and flexible UI integration.
/// </summary>
/// <remarks>
/// Split buttons merge a primary button and a dropdown menu, providing quick access to a default action while offering additional choices through the dropdown. They are ideal for commands with multiple variations where one option is used most frequently. The interface supports dynamic sizing, enabled state, visibility, label display, and keytips through callback functions. Split buttons are commonly used for paste operations, format commands, insert operations, save/export, and view modes. The structure consists of a primary action (button or toggle button), a dropdown menu, and visual/positioning properties for seamless ribbon integration.
/// </remarks>

public interface SplitButton : CustomUIControl, BoxContent, GroupContent
{
  /// <summary>
  /// Display size of the split button in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  /// Callback for dynamic button size.
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  /// Enable interaction with the split button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Arbitrary tag value for application-specific purposes.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Microsoft Office built-in control identifier to customize or reference.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Show the split button in the ribbon.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) that activates this split button.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip value.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the text label alongside the icon.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Primary button component that executes the default action.
  /// </summary>
  public VisibleButton? VisibleButton { get; set; }

  /// <summary>
  /// Primary toggle button component that toggles a feature on/off.
  /// </summary>
  public VisibleToggleButton? VisibleToggleButton { get; set; }

  /// <summary>
  /// Dropdown menu component containing additional options.
  /// </summary>
  public MenuRegular? MenuRegular { get; set; }
}