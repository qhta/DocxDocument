namespace DocumentModel;

/// <summary>
/// Represents a visible button control for Office UI, supporting dynamic state, customizable appearance, and advanced callback integration for flexible scenarios.
/// </summary>
/// <remarks>
/// This interface defines a button that can be placed in various Office UI contexts, supporting dynamic enabled state, labeling, images, tooltips, and flexible positioning. Callback integration enables runtime behavior, accessibility, and context-sensitive actions.
/// </remarks>
public interface VisibleButton: CustomUIControl, TaggedObject
{
  /// <summary>
  /// Callback executed when the button is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Enable interaction with the button.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Description text for the button.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Custom image identifier for the button icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the button icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic button image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Built-in Office identifier for a button control.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Screentip text for the button.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the button.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label text for the button.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the button.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the button label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the button image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }
}