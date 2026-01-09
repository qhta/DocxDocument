namespace DocumentModel;

/// <summary>
///   Represents a container control that organizes and layouts child controls within the ribbon interface, supporting flexible arrangement, styling, and nested content for advanced UI scenarios.
/// </summary>
/// <remarks>
///   This interface defines a flexible container that can hold
///   various types of controls including buttons, checkboxes, galleries, menus, and nested boxes.
///   Boxes provide layout capabilities with customizable styling to organize controls in a structured manner.
///   They support both horizontal and vertical arrangements depending on the specified box style.
/// </remarks>
public interface Box : BoxContentControl
{
  /// <summary>
  ///   Visual style that determines the layout behavior of the box.
  /// </summary>
  public BoxStyleKind? BoxStyle { get; set; }

  /// <summary>
  ///   Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlClone? ControlClone { get; set; }

  /// <summary>
  ///   Collection of child controls contained in the box.
  /// </summary>
  public BoxContentControls Children { get; set; }
}