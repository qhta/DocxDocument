namespace DocumentModel;

/// <summary>
/// Represents a group of controls in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage group with properties for identification, positioning, state, labeling, style, helper text, and access to top, bottom, and primary items. It enables dynamic visibility, enabled state, labeling, style selection, and flexible arrangement, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageGroup : QualifiedElement
{

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Built-in Office identifier for the Backstage group.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// ID of a built-in Office group after which this group should be inserted.
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  /// ID of a built-in Office group before which this group should be inserted.
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  /// Qualified ID of a custom group after which this group should be inserted.
  /// </summary>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  /// Qualified ID of a custom group before which this group should be inserted.
  /// </summary>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  /// Label text for the Backstage group.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the Backstage group in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Style for the Backstage group.
  /// </summary>
  public StyleKind? Style { get; set; }

  /// <summary>
  /// Callback for dynamic style selection.
  /// </summary>
  public string? GetStyle { get; set; }

  /// <summary>
  /// Helper text for the Backstage group.
  /// </summary>
  public string? HelperText { get; set; }

  /// <summary>
  /// Callback for dynamic helper text.
  /// </summary>
  public string? GetHelperText { get; set; }

  /// <summary>
  /// Show the group label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

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