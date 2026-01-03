namespace DocumentModel;

/// <summary>
///   Represents a hyperlink control in the Office backstage view that navigates to external resources or document locations.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a hyperlink control designed specifically for
///   use in Office backstage views (File menu). Unlike standard document hyperlinks that navigate within content,
///   backstage hyperlinks provide navigation to external web resources, other documents, or specific document locations
///   from within the backstage interface. The hyperlink control appears as a clickable text element with optional icon,
///   supporting both static and dynamic target URLs through the <see cref="Target"/> property or <see cref="GetTarget"/>
///   callback. The control includes comprehensive formatting options including label text, image, tooltips (screentip
///   and supertip), layout behavior (label alignment and expansion), and state management (enabled and visible states).
///   Hyperlinks in the backstage are commonly used for "Learn more" links, help documentation, online resources, or
///   navigation to related files or locations. The <see cref="OnAction"/> callback can override the default navigation
///   behavior to provide custom handling when the hyperlink is clicked. Properties can be set statically or determined
///   dynamically through callback functions, enabling responsive UI that adapts to application context and state.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface Hyperlink : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this hyperlink control.
  /// </summary>
  /// <value>
  ///   A string containing the identifier, or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this hyperlink control.
  /// </summary>
  /// <value>
  ///   A string containing the namespace-qualified identifier, or <c>null</c> if not specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
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
  ///   This property is only available in Office 2010 and later.
  ///   The tag can be used to store application-specific information associated with this hyperlink.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the alignment behavior of the hyperlink label.
  /// </summary>
  /// <value>
  ///   An <see cref="ExpandKind"/> value specifying how the label aligns or expands,
  ///   or <c>null</c> to use the default alignment behavior.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   This controls whether the label expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  ///   Gets or sets the expansion behavior of the hyperlink control.
  /// </summary>
  /// <value>
  ///   An <see cref="ExpandKind"/> value specifying how the hyperlink expands to fill available space,
  ///   or <c>null</c> to use the default expansion behavior.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   This controls whether the hyperlink expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the hyperlink is enabled and can be clicked.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the hyperlink is enabled; <c>false</c> if disabled; or <c>null</c> to use the default enabled state.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the hyperlink is enabled.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the enabled state is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the hyperlink should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the hyperlink is visible.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the hyperlink is visible; <c>false</c> if hidden; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's visibility.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if visibility is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a boolean value indicating whether the hyperlink should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the hyperlink.
  /// </summary>
  /// <value>
  ///   A string containing the keytip character(s), or <c>null</c> if no keytip is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's keytip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the keytip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the hyperlink.
  /// </summary>
  /// <value>
  ///   A string containing the label text, or <c>null</c> if no label is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The label is the clickable text that appears to the user, typically describing the link destination
  ///   or action (e.g., "Learn more", "View online help", "Open related document").
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's label.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the label is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when the hyperlink is clicked.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if using default navigation behavior.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   When specified, this callback overrides the default navigation to the <see cref="Target"/> URL,
  ///   allowing custom handling of the hyperlink click event. This is useful for implementing complex
  ///   navigation logic, validation, or actions beyond simple URL navigation.
  /// </remarks>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the hyperlink icon.
  /// </summary>
  /// <value>
  ///   A string containing the image identifier, or <c>null</c> if no custom image is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The image identifier references a custom image resource included in the Office add-in.
  ///   The image appears next to the hyperlink label.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the hyperlink icon.
  /// </summary>
  /// <value>
  ///   A string containing the Microsoft Office image identifier, or <c>null</c> if not using a built-in image.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Use this to display a built-in Office icon next to the hyperlink label.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's image.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the image is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the hyperlink.
  /// </summary>
  /// <value>
  ///   A string containing the screentip text, or <c>null</c> if no screentip is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The screentip appears when the user hovers over the hyperlink, providing brief information
  ///   about the link destination or purpose.
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's screentip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the screentip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the hyperlink.
  /// </summary>
  /// <value>
  ///   A string containing the supertip text, or <c>null</c> if no supertip is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   Supertips provide more detailed information than screentips, typically including a description
  ///   of what the user can expect when clicking the hyperlink.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's supertip.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the supertip is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the target URL or location that the hyperlink navigates to when clicked.
  /// </summary>
  /// <value>
  ///   A string containing the target URL (e.g., "https://example.com", "file:///C:/path/to/document.docx"),
  ///   or <c>null</c> if no target is specified or navigation is handled by <see cref="OnAction"/>.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The target can be a web URL (http:// or https://), a file path (file:///), a mailto link (mailto:),
  ///   or other URI schemes supported by the operating system. When both <see cref="Target"/> and
  ///   <see cref="OnAction"/> are specified, the OnAction callback takes precedence.
  /// </remarks>
  public string? Target { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's target URL.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if the target is not determined dynamically.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The callback function should return a string value containing the target URL or location.
  ///   This enables dynamic link destinations based on application state, user preferences, or other runtime conditions.
  /// </remarks>
  public string? GetTarget { get; set; }
}