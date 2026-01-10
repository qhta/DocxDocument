namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a split button control in the Office ribbon interface that combines a primary action button with a dropdown menu of related options, supporting dynamic behavior, advanced positioning, and flexible UI integration.
/// </summary>
/// <remarks>
/// Split buttons merge a primary button and a dropdown menu, providing quick access to a default action while offering additional choices through the dropdown. They are ideal for commands with multiple variations where one option is used most frequently. The interface supports dynamic sizing, enabled state, visibility, label display, and keytips through callback functions. Split buttons are commonly used for paste operations, format commands, insert operations, save/export, and view modes. The structure consists of a primary action (button or toggle button), a dropdown menu, and visual/positioning properties for seamless ribbon integration.
/// </remarks>

public interface SplitButton : CustomUIControl, TaggedObject, BuiltInObject,
  EnableControl, VisibleControl, KeytipControl, ShowLabelControl, SizeControl,
  BoxContent, GroupContent
{

  /// <summary>
  /// Primary button component that executes the default action.
  /// </summary>
  public VisibleButton? VisibleButton { get; set; }

  /// <summary>
  /// Primary toggle button component that toggles a feature on/off.
  /// </summary>
  public VisibleToggleButton? VisibleToggleButton { get; set; }

  /// <summary>
  /// Dropdown menu component containing additional options.
  /// </summary>
  public Menu? Menu{ get; set; }
}