namespace DocumentModel;

/// <summary>
/// Represents an edit box control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage edit box with properties for identification, alignment, expansion, state, labeling, text input, and layout. It enables dynamic visibility, enabled state, labeling, and text value, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageEditBox: QualifiedElement, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ChangeControl,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{

  /// <summary>
  /// Alignment behavior of the label control.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the edit box control.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Maximum number of characters that can be entered in the text field.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  /// String representation of the edit box size in the Backstage view.
  /// </summary>
  public string? SizeString { get; set; }
}