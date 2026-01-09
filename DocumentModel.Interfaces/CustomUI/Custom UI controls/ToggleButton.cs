namespace DocumentModel;

/// <summary>
/// Represents a toggle button control that maintains an on/off pressed state in the ribbon interface, supporting customizable appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a button control that toggles between pressed (on) and unpressed (off) states when clicked. Unlike a standard <see cref="Button"/> which executes a single action, toggle buttons maintain their state to indicate whether a feature or option is currently active. They are commonly used for formatting options (like Bold or Italic) or to show/hide UI elements. The control supports customizable appearance with images, labels, tooltips, sizing options, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ToggleButton : BoxContentControl
{
  /// <summary>
  /// Size of the toggle button control in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  /// Callback for dynamic toggle button size.
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  /// Callback for dynamic pressed state of the toggle button.
  /// </summary>
  public string? GetPressed { get; set; }

  /// <summary>
  /// Callback executed when the toggle button is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Enable interaction with the toggle button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Description text for the toggle button.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Custom image identifier for the toggle button icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the toggle button icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic toggle button image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Built-in Office identifier for a toggle button control.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Screentip text for the toggle button.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the toggle button.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label displayed for the toggle button.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the toggle button in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the toggle button.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the toggle button label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the toggle button image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }
}