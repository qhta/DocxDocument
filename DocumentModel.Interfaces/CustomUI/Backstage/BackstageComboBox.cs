namespace DocumentModel;

/// <summary>
/// Represents a combo box control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage combo box with properties for identification, alignment, expansion, state, labeling, text input, item management, and layout. It enables dynamic visibility, enabled state, labeling, item count, and text value, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageComboBox: QualifiedElement, TaggedObject
{

  /// <summary>
  /// Alignment behavior of the label control.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the combo box control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Enable interaction with the combo box.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

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
  /// Callback for dynamic text value of the combo box.
  /// </summary>
  public string? GetText { get; set; }

  /// <summary>
  /// Callback executed when the combo box text changes.
  /// </summary>
  public string? OnChange { get; set; }

  /// <summary>
  /// String representation of the combo box size in the Backstage view.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Callback for dynamic item count.
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  /// Callback for dynamic item label.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  /// Callback for dynamic item identifier.
  /// </summary>
  public string? GetItemID { get; set; }

  /// <summary>
  /// Collection of items displayed in the combo box.
  /// </summary>
  public BackstageItems? BackstageItems { get; set; }
}