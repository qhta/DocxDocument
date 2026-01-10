namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a label control for the ribbon interface, supporting static and dynamic labeling, visibility, tooltips, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a label control that can be used within box containers and other layout controls in the ribbon. It supports static and callback-based values for label, visibility, enabled state, tooltips, and show label options. The control can be uniquely identified, supports Office built-in icons, and provides accessibility features through screentip and supertip properties. Label controls are useful for displaying descriptive text, section headers, or instructions within custom UI layouts.
/// </remarks>
public interface LabelControl : CustomUIControl, BuiltInObject, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ScreentipControl, SupertipControl,
  BoxContent, GroupContent
{

}