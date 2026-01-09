namespace DocumentModel;

/// <summary>
/// Represents a regular toggle button control that maintains an on/off pressed state, suitable for use within menus and button groups, supporting streamlined appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a streamlined toggle button control optimized for use within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard <see cref="ToggleButton"/> control which has additional sizing options, ToggleButtonRegular provides a simplified toggle button implementation that maintains consistent dimensions appropriate for its context. Like all toggle buttons, it maintains a pressed (on) or unpressed (off) state to indicate whether a feature or option is currently active. The control is commonly used for formatting options or to show/hide UI elements in compact contexts, and supports customizable appearance with images, labels, tooltips, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ToggleButtonRegular : CustomUIControl, BuiltInControl
{
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