namespace DocumentModel;

/// <summary>
/// Represents an individual task within a task form group category, supporting dynamic state, customizable appearance, and advanced callback integration for flexible task pane scenarios.
/// </summary>
/// <remarks>
/// This interface defines a single actionable task within a <c>TaskFormGroupCategory</c>. Tasks provide interactive elements with customizable appearance, behavior, and positioning within the task pane UI. The interface supports dynamic state, labeling, image customization, and integration with backstage groups for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskFormGroupTask : CustomUIControl, BuiltInControl, TaggedObject, 
  EnableControl, VisibleControl, LabelledControl, DescriptionControl, KeytipControl, ImagedControl,
  BackstageGroupCollection
{


}