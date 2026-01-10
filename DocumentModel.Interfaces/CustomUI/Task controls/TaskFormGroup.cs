namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a group of controls within a task form in the Office UI, supporting logical organization, dynamic state, and advanced callback integration for flexible task pane scenarios.
/// </summary>
/// <remarks>
/// This interface defines a logical grouping of controls displayed in a task pane or form. Task form groups organize related controls and provide options for labeling, visibility, sizing, and dynamic behavior through callback functions for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskFormGroup : QualifiedElement, BuiltInObject, TaggedObject, 
  VisibleControl, LabelledControl, ShowLabelControl, HelperControl,
  TaskFormGroupCategoryCollection
{

  /// <summary>
  /// Allowed task sizes for this group.
  /// </summary>
  public TaskSizesKind? AllowedTaskSizes { get; set; }
}