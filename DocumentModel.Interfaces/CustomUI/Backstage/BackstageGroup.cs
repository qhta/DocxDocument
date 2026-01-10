namespace DocumentModel;

/// <summary>
/// Represents a group of controls in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage group with properties for identification, positioning, state, labeling, style, helper text, and access to top, bottom, and primary items. It enables dynamic visibility, enabled state, labeling, style selection, and flexible arrangement, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageGroup : CustomUIControl, BuiltInObject, TaggedObject,
  EnableControl, VisibleControl,
  LabelledControl,
  HelperControl,
  ShowLabelControl
{

  /// <summary>
  /// Style for the Backstage group.
  /// </summary>
  public StyleKind? Style { get; set; }

  /// <summary>
  /// Callback for dynamic style selection.
  /// </summary>
  public string? GetStyle { get; set; }

  /// <summary>
  /// Primary item displayed in the group.
  /// </summary>
  public PrimaryItem? PrimaryItem { get; set; }

  /// <summary>
  /// Top-level controls displayed in the group.
  /// </summary>
  public TopItemsGroupControls? TopItemsGroupControls { get; set; }

  /// <summary>
  /// Bottom-level controls displayed in the group.
  /// </summary>
  public BottomItemsGroupControls? BottomItemsGroupControls { get; set; }
}