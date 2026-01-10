namespace DocumentModel.CustomUI;

/// <summary>
///   Represents a cloned instance of a built-in or custom Office ribbon control with customizable properties.
/// </summary>
/// <remarks>
/// Features:
/// <list type="bullet">
/// <item>Replicates an existing Office control while allowing customization of its properties.</item>
/// <item>Enables reuse of control definitions without duplicating implementation.</item>
/// <item>Supports dynamic property determination through callback functions.</item>
/// </list>
/// </remarks>
public interface ControlClone: CustomUIControl, BuiltInObject, TaggedObject,
  DescriptionControl, SizeControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl

{

}