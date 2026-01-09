namespace DocumentModel;

/// <summary>
/// Represents a label control for the ribbon interface, supporting static and dynamic labeling, visibility, tooltips, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a label control that can be used within box containers and other layout controls in the ribbon. It supports static and callback-based values for label, visibility, enabled state, tooltips, and show label options. The control can be uniquely identified, supports Office built-in icons, and provides accessibility features through screentip and supertip properties. Label controls are useful for displaying descriptive text, section headers, or instructions within custom UI layouts.
/// </remarks>
public interface LabelControl : CustomUIControl, BuiltInControl, BoxContent, GroupContent
{
  /// <summary>
  /// Custom tag for storing additional metadata or for programmatic grouping.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Screentip text for the label control.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the label control.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Enable interaction with the label control.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the control.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the label control in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Show the label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }
}