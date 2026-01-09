namespace DocumentModel;

/// <summary>
/// Represents a radio group control that provides mutually exclusive selection options, supporting dynamic content, customizable labeling, layout expansion, and advanced callback integration for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a control that presents a set of radio button options where only one item can be selected at a time. Radio groups are commonly used in backstage views and other Office UI contexts to allow users to choose from a predefined set of mutually exclusive options. The control supports both static and dynamic content generation, with options for customizable labels, layout expansion, keyboard shortcuts, and enabled/visible states that can be controlled through static properties or dynamic callbacks.
/// </remarks>
public interface RadioGroup : IdentifiedElement, TaggedObject
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Alignment behavior of the radio group label.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the radio group.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Enable interaction with the radio group.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label displayed for the radio group.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the radio group in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Callback executed when a radio button selection changes.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the radio group.
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
  /// Collection of radio button items displayed in the group.
  /// </summary>
  public BackstageItems? RadioButtonBackstageItems { get; set; }
}