namespace DocumentModel;

/// <summary>
/// Represents a check box control for the ribbon interface, supporting dynamic state, labeling, tooltips, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a check box control that can be used within box containers and other layout controls in the ribbon. It supports static and callback-based values for pressed state, enabled state, label, description, tooltips, and visibility. The control can be uniquely identified, supports Office built-in icons, and provides accessibility features through screentip and supertip properties. Check boxes are useful for boolean selection, toggling options, and interactive scenarios within custom UI layouts.
/// </remarks>
public interface CheckBox : CustomUIControl, BuiltInObject, TaggedObject,
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl,
  PressedControl, ActionControl,
  KeytipControl, ScreentipControl, SupertipControl,
  BoxContent, ContextMenuContent, MenuContent, MenuRegularContent
{
}