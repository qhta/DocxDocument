namespace DocumentModel;

/// <summary>
///   Represents a regular toggle button control that maintains an on/off pressed state, suitable for use within menus and button groups.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a streamlined toggle button control optimized for use
///   within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard
///   <see cref="ToggleButton"/> control which has additional sizing options, ToggleButtonRegular provides a simplified
///   toggle button implementation that maintains consistent dimensions appropriate for its context. Like all toggle buttons,
///   it maintains a pressed (on) or unpressed (off) state to indicate whether a feature or option is currently active.
///   The control is commonly used for formatting options or to show/hide UI elements in compact contexts, and supports
///   customizable appearance with images, labels, tooltips, and can have its state and behavior controlled through
///   static properties or dynamic callbacks.
/// </remarks>
public interface ToggleButtonRegular : IModelElement
{
  /// <summary>
  ///   Gets or sets the name of a callback function that returns the current pressed state of the toggle button.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value: <c>true</c> if the button is pressed (on),
  ///   <c>false</c> if unpressed (off). This is the primary mechanism for synchronizing the button's
  ///   visual state with the application's state.
  /// </remarks>
  public string? GetPressed { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when the toggle button is clicked.
  /// </summary>
  /// <remarks>
  ///   The callback function is invoked each time the button is clicked to toggle its state.
  /// </remarks>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the toggle button is enabled and can be clicked.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the toggle button is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the button should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the description text that provides additional information about the toggle button.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's description.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the toggle button icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the toggle button icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the button.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for this toggle button.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this toggle button.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this toggle button.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier for a built-in Microsoft Office toggle button.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the toggle button.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the toggle button.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the toggle button.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this toggle button should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this toggle button should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this toggle button should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this toggle button should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the button relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the toggle button is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the button should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the toggle button.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the toggle button's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the toggle button's label should be displayed.
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
  ///   Gets or sets a value indicating whether the toggle button's image should be displayed.
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