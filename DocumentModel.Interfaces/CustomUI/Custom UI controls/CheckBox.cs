namespace DocumentModel;

/// <summary>
/// Represents a check box control for the ribbon interface, supporting dynamic state, labeling, tooltips, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a check box control that can be used within box containers and other layout controls in the ribbon. It supports static and callback-based values for pressed state, enabled state, label, description, tooltips, and visibility. The control can be uniquely identified, supports Office built-in icons, and provides accessibility features through screentip and supertip properties. Check boxes are useful for boolean selection, toggling options, and interactive scenarios within custom UI layouts.
/// </remarks>
public interface CheckBox : CustomUIControl, BuiltInControl, BoxContent, ContextMenuContent
{
  /// <summary>
  /// Callback for dynamic pressed state of the check box.
  /// </summary>
  public string? GetPressed { get; set; }

  /// <summary>
  /// Callback executed when the check box is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Enable interaction with the check box.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Description text for the check box.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Custom tag for storing additional metadata or for programmatic grouping.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Screentip text for the check box.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the check box.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label text for the check box.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the check box in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the check box.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }
}