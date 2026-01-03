namespace DocumentModel;

/// <summary>
///   Represents an edit box control that provides a text input field for user entry in the ribbon interface.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a text input control that allows users
///   to enter and edit text directly within the ribbon. Unlike a <see cref="ComboBox"/> which combines text
///   input with a dropdown list, the edit box provides a simple text field without predefined options.
///   The control supports text length constraints, change notifications, customizable appearance with images
///   and labels, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface EditBox : IModelElement
{
  /// <summary>
  ///   Gets or sets a value indicating whether the edit box is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the edit box is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the edit box should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the edit box icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the edit box icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the edit box.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the edit box's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the maximum number of characters that can be entered in the text field.
  /// </summary>
  /// <remarks>
  ///   This constraint helps validate and limit user input to an acceptable length.
  /// </remarks>
  public Int64? MaxLength { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that returns the current text value of the edit box.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string representing the current text in the edit box.
  /// </remarks>
  public string? GetText { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when the edit box text changes.
  /// </summary>
  /// <remarks>
  ///   The callback function is invoked when the user modifies the text content and typically when focus leaves the control.
  /// </remarks>
  public string? OnChange { get; set; }

  /// <summary>
  ///   Gets or sets the string representation of the edit box size.
  /// </summary>
  /// <remarks>
  ///   This controls the width of the edit box in the ribbon.
  /// </remarks>
  public string? SizeString { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this edit box.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this edit box.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this edit box.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office edit box.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the edit box.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the edit box's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the edit box.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the edit box's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the edit box.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the edit box's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this edit box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the edit box relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this edit box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the edit box relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this edit box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the edit box relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this edit box should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the edit box relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the edit box is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the edit box's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the edit box should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the edit box.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the edit box's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the edit box's label should be displayed.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the edit box's image should be displayed.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the image is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the image should be displayed.
  /// </remarks>
  public string? GetShowImage { get; set; }
}