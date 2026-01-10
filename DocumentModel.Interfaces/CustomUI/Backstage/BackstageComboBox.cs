namespace DocumentModel;

/// <summary>
/// Represents a combo box control for the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage combo box with properties for identification, alignment, expansion, state, labeling, text input, item management, and layout. It enables dynamic visibility, enabled state, labeling, item count, and text value, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageComboBox: QualifiedElement, TaggedObject,
  LabelledControl,
  EnableControl, VisibleControl,
  KeytipControl, ScreentipControl,
  ItemsControl,
  ChangeControl,
  BackstageItemCollection,
  GroupBoxContent, LayoutContent
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
  /// Callback for dynamic text value of the combo box.
  /// </summary>
  public string? GetText { get; set; }

  /// <summary>
  /// String representation of the combo box size in the Backstage view.
  /// </summary>
  public string? SizeString { get; set; }

}