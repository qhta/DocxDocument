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
public interface ControlCloneRegular
{
  /// <summary>
  ///   Gets or sets the qualified identifier of the custom control to clone.
  /// </summary>
  /// <remarks>
  ///   Use this to clone a previously defined custom control for use in menus or button groups.
  ///   Either <see cref="QualifiedId"/> or <see cref="IdMso"/> should be specified to identify the
  ///   source control, but typically not both.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this cloned control.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the identifier of the built-in Microsoft Office control to clone.
  /// </summary>
  /// <remarks>
  ///   Use this to clone a built-in Office command or control for use in menus or button groups.
  ///   Either <see cref="IdMso"/> or <see cref="QualifiedId"/> should be specified to identify the
  ///   source control, but typically not both.
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the cloned control's icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the cloned control's icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the control.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the cloned control.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the cloned control.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the cloned control is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the cloned control is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the control should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the cloned control.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this cloned control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the cloned control relative to a built-in control within its container.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this cloned control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the cloned control relative to a built-in control within its container.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this cloned control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the cloned control relative to another custom control within its container.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this cloned control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the cloned control relative to another custom control within its container.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the cloned control is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the control should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the cloned control.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the cloned control's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the cloned control's label should be displayed.
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
  ///   Gets or sets a value indicating whether the cloned control's image should be displayed.
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