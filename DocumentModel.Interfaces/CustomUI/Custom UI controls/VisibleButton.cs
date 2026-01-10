namespace DocumentModel;

/// <summary>
/// Represents a visible button control for Office UI, supporting dynamic state, customizable appearance, and advanced callback integration for flexible scenarios.
/// </summary>
/// <remarks>
/// This interface defines a button that can be placed in various Office UI contexts, supporting dynamic enabled state, labeling, images, tooltips, and flexible positioning. Callback integration enables runtime behavior, accessibility, and context-sensitive actions.
/// </remarks>
public interface VisibleButton: CustomUIControl, TaggedObject, BuiltInControl,
  EnableControl, VisibleControl, 
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  DescriptionControl, 
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl
{

}