namespace DocumentModel;

/// <summary>
/// Represents a label control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage label control with properties for identification, alignment, expansion, state, labeling, and wrapping. It enables dynamic visibility, enabled state, labeling, and layout adjustments, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageLabelControl: QualifiedElement, TaggedObject,
  EnableControl, VisibleControl,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{

  /// <summary>
  /// Alignment behavior of the label control.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the label control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Label text for the control.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Prevent label text from wrapping.
  /// </summary>
  public bool? NoWrap { get; set; }
}