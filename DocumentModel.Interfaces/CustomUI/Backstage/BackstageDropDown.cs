namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a dropdown control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage dropdown with properties for identification, alignment, expansion, state, labeling, selection, tooltips, and item management. It enables dynamic visibility, enabled state, labeling, item count, and selection, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageDropDown: QualifiedElement, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ItemsControl, SelectedItemControl,
  ActionControl,
  BackstageItemCollection,
  GroupBoxContent, LayoutContent, BackstageGroupContent
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
  /// String representation of the dropdown size in the Backstage view.
  /// </summary>
  public string? SizeString { get; set; }
}