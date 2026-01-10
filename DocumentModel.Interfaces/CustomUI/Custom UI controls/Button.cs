namespace DocumentModel;

/// <summary>
/// Represents a button control that executes an action when clicked in the ribbon interface, supporting customizable appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a clickable button control that can be placed in various ribbon locations such as groups, menus, and containers. Buttons support customizable appearance with images, labels, tooltips, keyboard shortcuts, and can have their state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface Button : CustomUIControl, BuiltInControl, TaggedObject, 
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl,
  BoxContent, GroupContent
{
}