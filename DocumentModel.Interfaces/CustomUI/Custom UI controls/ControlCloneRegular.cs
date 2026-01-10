namespace DocumentModel;

/// <summary>
///   Represents a regular cloned control optimized for use within menus and button groups.
/// </summary>
/// <remarks>
///   This interface defines a streamlined control clone specifically
///   designed for constrained ribbon contexts such as menus, button groups, and split buttons. Similar to
///   <see cref="ControlClone"/>, this interface enables replication of existing controls (either built-in
///   Office commands or custom controls) while allowing customization of appearance, behavior, and positioning.
///   However, ControlCloneRegular is optimized for contexts where controls are displayed in a more compact
///   format with consistent dimensions appropriate for their container. Unlike the standard <see cref="ControlClone"/>
///   which includes sizing options, ControlCloneRegular provides a simplified control clone implementation that
///   maintains fixed dimensions suitable for menu and button group contexts. The cloned control inherits the base
///   functionality of its source control but can override specific properties such as label, image, visibility,
///   enabled state, and positioning. Properties can be set statically or determined dynamically through callback
///   functions, enabling responsive UI that adapts to application state. The control references its source through
///   either a built-in Microsoft Office identifier (IdMso) or a qualified custom control identifier (QualifiedId).
///   This streamlined approach is particularly useful for adding built-in Office commands to custom menus or
///   reusing complex custom controls across multiple menu locations with slight variations.
/// </remarks>
public interface ControlCloneRegular: CustomUIControl, TaggedObject, BuiltInObject,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl
{

}