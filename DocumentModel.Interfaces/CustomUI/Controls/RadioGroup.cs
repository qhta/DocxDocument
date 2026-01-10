namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a radio group control that provides mutually exclusive selection options, supporting dynamic content, customizable labeling, layout expansion, and advanced callback integration for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a control that presents a set of radio button options where only one item can be selected at a time. Radio groups are commonly used in backstage views and other Office UI contexts to allow users to choose from a predefined set of mutually exclusive options. The control supports both static and dynamic content generation, with options for customizable labels, layout expansion, keyboard shortcuts, and enabled/visible states that can be controlled through static properties or dynamic callbacks.
/// </remarks>
public interface RadioGroup : IdentifiedElement, TaggedObject,
  EnableControl, VisibleControl, LabelledControl, KeytipControl,
  ActionControl,
  BackstageItemCollection,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{

  /// <summary>
  /// Alignment behavior of the radio group label.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the radio group.
  /// </summary>
  public ExpandKind? Expand { get; set; }

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

}