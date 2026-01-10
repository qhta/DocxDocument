namespace DocumentModel;

/// <summary>
/// Represents a toggle button control that maintains an on/off pressed state in the ribbon interface, supporting customizable appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a button control that toggles between pressed (on) and unpressed (off) states when clicked. Unlike a standard <see cref="Button"/> which executes a single action, toggle buttons maintain their state to indicate whether a feature or option is currently active. They are commonly used for formatting options (like Bold or Italic) or to show/hide UI elements. The control supports customizable appearance with images, labels, tooltips, sizing options, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ToggleButton : CustomUIControl, BuiltInObject, TaggedObject, 
  EnableControl, VisibleControl, DescriptionControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  PressedControl, ActionControl,
  SizeControl,
  BoxContent, GroupContent
{

}