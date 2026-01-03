namespace DocumentModel;

/// <summary>
///   Represents a regular button control that executes an action when clicked, suitable for use within menus and button groups.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a streamlined button control optimized for use
///   within constrained ribbon contexts such as menus, button groups, and split buttons. Unlike the standard
///   <see cref="Button"/> control which has additional sizing options, ButtonRegular provides a simplified button
///   implementation that maintains consistent dimensions appropriate for its context. The control supports
///   customizable appearance with images, labels, tooltips, keyboard shortcuts, and can have its state and
///   behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ButtonRegular : IModelElement
{
  /// <summary>
  ///   Gets or sets the name of the callback function executed when the button is clicked.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if no action is defined.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the button is enabled and can be clicked.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the button is enabled; <c>false</c> if disabled; or <c>null</c> to use the default enabled state.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the button is enabled.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the enabled state is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the button should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the description text that provides additional information about the button.
  /// </summary>
  /// <value>
  ///   A string containing the description text, or <c>null</c> if no description is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's description.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the description is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the button icon.
  /// </summary>
  /// <value>
  ///   A string containing the image identifier, or <c>null</c> if no custom image is specified.
  /// </value>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the button icon.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office image identifier, or <c>null</c> if not using a built-in image.
  /// </value>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's image.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the image is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this button.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this button.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <value>
  ///   A string containing custom tag data, or <c>null</c> if no tag is specified.
  /// </value>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this button.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office button.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if not referencing a built-in button.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the button.
  /// </summary>
  /// <value>
  ///   A string containing the screentip text, or <c>null</c> if no screentip is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's screentip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the screentip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the button.
  /// </summary>
  /// <value>
  ///   A string containing the supertip text, or <c>null</c> if no supertip is specified.
  /// </value>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's supertip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the supertip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the button.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this button should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the button relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this button should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the button relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this button should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the button relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this button should be inserted.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if position is not specified.
  /// </value>
  /// <remarks>
  ///   Use this to position the button relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the button is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the button is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the button should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the button.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the button's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the button's label should be displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the label is shown; <c>false</c> if hidden; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if label visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the button's image should be displayed.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the image is shown; <c>false</c> if hidden; or <c>null</c> to use the default behavior.
  /// </value>
  /// <remarks>
  /// </remarks>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the image is shown.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if image visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the image should be displayed.
  /// </remarks>
  public string? GetShowImage { get; set; }
}