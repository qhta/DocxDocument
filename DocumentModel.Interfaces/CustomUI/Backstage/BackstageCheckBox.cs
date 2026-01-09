namespace DocumentModel;

/// <summary>
/// Represents a checkbox control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage checkbox with properties for expansion, description, tooltips, identification, state, labeling, keytips, and pressed state. It enables dynamic visibility, enabled state, labeling, and pressed state, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageCheckBox: QualifiedElement, TaggedObject
{
  /// <summary>
  /// Expansion behavior of the checkbox control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Description text for the Backstage checkbox.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Screentip text for the checkbox.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the checkbox.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Callback executed when the checkbox is clicked.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Callback for dynamic pressed state of the checkbox.
  /// </summary>
  public string? GetPressed { get; set; }

  /// <summary>
  /// Enable interaction with the checkbox.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the checkbox.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the checkbox in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the checkbox.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }
}