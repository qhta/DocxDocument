namespace DocumentModel;

/// <summary>
/// Represents a dropdown control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage dropdown with properties for identification, alignment, expansion, state, labeling, selection, tooltips, and item management. It enables dynamic visibility, enabled state, labeling, item count, and selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageDropDown: QualifiedElement, TaggedObject
{

  /// <summary>
  /// Alignment behavior of the label control.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the dropdown control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Enable interaction with the dropdown.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the dropdown.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the dropdown in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Callback executed when a dropdown item is selected.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Screentip text for the dropdown.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the dropdown.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the dropdown.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Callback for dynamic selected item index.
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  /// String representation of the dropdown size in the Backstage view.
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
  /// Collection of items displayed in the dropdown.
  /// </summary>
  public BackstageItems? BackstageItems { get; set; }
}