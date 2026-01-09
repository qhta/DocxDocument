namespace DocumentModel;

/// <summary>
/// Represents a checkbox item in the Office Backstage menu, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu checkbox with properties for description, identification, state, labeling, keytips, and pressed state. It enables dynamic visibility, enabled state, labeling, and pressed state, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageMenuCheckBox: QualifiedElement
{
  /// <summary>
  /// Description text for the Backstage menu checkbox.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

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