namespace DocumentModel;

/// <summary>
///   Represents a cloned control specifically designed for the Quick Access Toolbar (QAT) in Office applications.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a control clone optimized for use in the
///   Quick Access Toolbar, which provides users with convenient access to frequently used commands above or below
///   the ribbon. Similar to <see cref="ControlClone"/>, this interface enables replication of existing controls
///   (either built-in Office commands or custom controls) while allowing customization of appearance, behavior,
///   and positioning. However, ControlCloneQat is specifically tailored for the QAT context, where controls are
///   typically displayed in a more compact format and have unique positioning requirements. The cloned control
///   inherits the base functionality of its source control but can override specific properties such as size,
///   label, image, visibility, enabled state, and positioning within the QAT. The Quick Access Toolbar is a
///   user-customizable area that remains consistently visible regardless of which ribbon tab is active, making
///   it ideal for commands that users need throughout their workflow. Properties can be set statically or
///   determined dynamically through callback functions, enabling responsive UI that adapts to application state.
///   The control is identified through its own ID and references its source through either a built-in Microsoft
///   Office identifier (IdMso) or a qualified custom control identifier (IdQ).
/// </remarks>
public interface ControlCloneQat : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this QAT control clone.
  /// </summary>
  /// <remarks>
  ///   The identifier uniquely distinguishes this control clone within the Quick Access Toolbar,
  ///   enabling references and management of the control instance.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier of the custom control to clone for the QAT.
  /// </summary>
  /// <remarks>
  ///   Use this to clone a previously defined custom control for use in the Quick Access Toolbar.
  ///   Either <see cref="IdQ"/> or <see cref="IdMso"/> should be specified to identify the source
  ///   control, but typically not both.
  /// </remarks>
  public string? IdQ { get; set; }

  /// <summary>
  ///   Gets or sets the identifier of the built-in Microsoft Office control to clone for the QAT.
  /// </summary>
  /// <remarks>
  ///   Use this to clone a built-in Office command or control for use in the Quick Access Toolbar.
  ///   Either <see cref="IdMso"/> or <see cref="IdQ"/> should be specified to identify the source
  ///   control, but typically not both.
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  ///   Gets or sets the description text that provides additional information about the QAT control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's description.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the description.
  /// </remarks>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   Gets or sets the size of the cloned control in the Quick Access Toolbar.
  /// </summary>
  /// <remarks>
  ///   Note that the Quick Access Toolbar typically displays controls in a more compact format than
  ///   the ribbon, which may affect how size settings are applied.
  /// </remarks>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's size.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a <see cref="SizeKind"/> value.
  /// </remarks>
  public string? GetSize { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the QAT control's icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the QAT control's icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon for the control in the Quick Access Toolbar.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the QAT control.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the QAT control.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the QAT control is enabled and can be interacted with.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the QAT control is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the control should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the QAT control.
  /// </summary>
  /// <remarks>
  ///   Note that Quick Access Toolbar controls often display only icons to conserve space, with labels
  ///   appearing primarily in tooltips. The <see cref="ShowLabel"/> property controls label visibility.
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this QAT control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the QAT control relative to a built-in control in the Quick Access Toolbar.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this QAT control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the QAT control relative to a built-in control in the Quick Access Toolbar.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this QAT control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the QAT control relative to another custom control in the Quick Access Toolbar.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this QAT control should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the QAT control relative to another custom control in the Quick Access Toolbar.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the QAT control is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the control should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the QAT control.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the QAT control's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the QAT control's label should be displayed.
  /// </summary>
  /// <remarks>
  ///   The Quick Access Toolbar typically shows only icons to conserve space, but labels can be enabled
  ///   if desired. When hidden, the label text still appears in tooltips.
  /// </remarks>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the label should be displayed.
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the QAT control's image should be displayed.
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