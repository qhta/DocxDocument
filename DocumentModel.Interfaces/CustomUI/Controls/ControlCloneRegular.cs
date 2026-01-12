namespace DocumentModel.CustomUI;

/// <summary>
///   Represents a regular cloned control optimized for use within menus and button groups.
/// </summary>
/// <remarks>
/// Features:
/// <list type="bullet">
/// <item>Used to clone a built-in Office control, but specifically for use in more constrained
/// or “regular” contexts, such as inside menus, button groups, or split buttons.</item>
/// <item>Designed for scenarios where a compact, uniform control is needed,
/// and advanced placement or sizing is not required.</item>
/// </list>
/// </remarks>
public interface ControlCloneRegular: CustomUIControl, TaggedObject, BuiltInObject,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl
{

}