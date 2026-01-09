namespace DocumentModel;

/// <summary>
/// Represents an edit box control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage edit box with properties for identification, alignment, expansion, state, labeling, text input, and layout. It enables dynamic visibility, enabled state, labeling, and text value, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageEditBox: QualifiedElement
{

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Alignment behavior of the label control.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the edit box control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Enable interaction with the edit box.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the edit box.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the edit box in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the edit box.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Callback for dynamic text value of the edit box.
  /// </summary>
  public string? GetText { get; set; }

  /// <summary>
  /// Callback executed when the edit box text changes.
  /// </summary>
  public string? OnChange { get; set; }

  /// <summary>
  /// Maximum number of characters that can be entered in the text field.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  /// String representation of the edit box size in the Backstage view.
  /// </summary>
  public string? SizeString { get; set; }
}