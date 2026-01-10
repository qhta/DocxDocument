namespace DocumentModel;

/// <summary>
/// Represents an edit box control that provides a text input field for user entry in the ribbon interface, supporting customizable appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a text input control that allows users to enter and edit text directly within the ribbon. Unlike a <see cref="ComboBox"/> which combines text input with a dropdown list, the edit box provides a simple text field without predefined options. The control supports text length constraints, change notifications, customizable appearance with images and labels, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface EditBox : CustomUIControl, BuiltInObject, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ChangeControl,
  BoxContent, GroupContent
{
  /// <summary>
  /// Maximum number of characters that can be entered in the text field.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  /// String representation of the edit box size in the ribbon.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Callback for dynamic text value of the edit box.
  /// </summary>
  public string? GetText { get; set; }

}