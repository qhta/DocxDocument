namespace DocumentModel;

/// <summary>
///   Represents a cloned instance of a built-in or custom Office ribbon control with customizable properties.
/// </summary>
/// <remarks>
///   This interface defines a control clone that replicates an existing
///   Office control (either built-in or custom) while allowing customization of its appearance, behavior, and
///   positioning. Control clones enable add-ins to reuse existing control definitions without duplicating their
///   entire implementation, providing an efficient way to include standard Office commands or previously defined
///   custom controls in new contexts with modified properties. The cloned control inherits the base functionality
///   of its source control but can override specific properties such as size, label, image, visibility, enabled
///   state, and positioning. This is particularly useful for adding built-in Office commands to custom ribbon
///   tabs or reusing complex custom controls across multiple ribbon locations with slight variations. Properties
///   can be set statically or determined dynamically through callback functions, enabling responsive UI that
///   adapts to application state. The control clone references its source through either a built-in Microsoft
///   Office identifier (IdMso) or a qualified custom control identifier (QualifiedId).
/// </remarks>
public interface ControlClone: CustomUIControl, BuiltInControl, TaggedObject,
  DescriptionControl,
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl

{
  /// <summary>
  ///   Gets or sets the size of the cloned control in the ribbon.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's size.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a <see cref="SizeKind"/> value.
  /// </remarks>
  public string? GetSize { get; set; }

}