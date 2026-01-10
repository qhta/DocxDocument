namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a combo box control that combines text input with a dropdown list of selectable items, supporting dynamic content, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a combo box control that allows users to either type text directly or select from a predefined list of options. Unlike a simple dropdown, the combo box provides an editable text field, making it suitable for scenarios where users need flexibility to enter custom values or select from suggestions. The control supports both static and dynamic content generation, customizable appearance with images and labels, text length constraints, and change notifications. It can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ComboBox : CustomUIControl, BuiltInObject, TaggedObject, 
  EnableControl, VisibleControl,
  LabelledControl, ShowLabelControl,
  ImagedControl, ShowImageControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ChangeControl,
  ItemsControl,
  SelectionItemCollection,
  BoxContent, GroupContent
{

  /// <summary>
  /// String representation of the combo box size.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Invalidate dropdown content when the dropdown is closed.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  /// Maximum number of characters that can be entered in the text field.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  /// Callback for dynamic text value of the combo box.
  /// </summary>
  public string? GetText { get; set; }

}