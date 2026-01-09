namespace DocumentModel;

/// <summary>
/// Represents a task item within a task group category for Office UI, supporting dynamic state, customizable appearance, and advanced callback integration for flexible task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines a task group task for Office UI, enabling tagging, action callbacks, definitive state, image customization, dynamic state, labeling, visibility, description, and keytip support. It supports advanced workflows for task management, integration, and extensibility in Office add-ins or document solutions.
/// </remarks>
public interface TaskGroupTask : CustomUIControl, BuiltInControl, TaggedObject,
    VisibleControl, LabelledControl, ImagedControl, DescriptionControl, EnableControl, KeyTipControl,
    ActionControl
{

  /// <summary>
  /// Indicates whether the task is definitive.
  /// </summary>
  public bool? IsDefinitive { get; set; }

}