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
/// </remarks>
public interface Hyperlink : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this hyperlink control.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this hyperlink control.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this hyperlink.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the alignment behavior of the hyperlink label.
  /// </summary>
  /// <remarks>
  ///   This controls whether the label expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  ///   Gets or sets the expansion behavior of the hyperlink control.
  /// </summary>
  /// <remarks>
  ///   This controls whether the hyperlink expands horizontally, vertically, or both to utilize available layout space.
  /// </remarks>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the hyperlink is enabled and can be clicked.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines whether the hyperlink is enabled.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the hyperlink should be enabled.
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the hyperlink is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the hyperlink should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the keyboard shortcut (keytip) for accessing the hyperlink.
  /// </summary>
  /// <remarks>
  ///   Keytips are displayed when the user presses the Alt key and provide keyboard-based navigation.
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's keytip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the keytip.
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   Gets or sets the display label for the hyperlink.
  /// </summary>
  /// <remarks>
  ///   The label is the clickable text that appears to the user, typically describing the link destination
  ///   or action (e.g., "Learn more", "View online help", "Open related document").
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's label.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the label.
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function executed when the hyperlink is clicked.
  /// </summary>
  /// <remarks>
  ///   When specified, this callback overrides the default navigation to the <see cref="Target"/> URL,
  ///   allowing custom handling of the hyperlink click event. This is useful for implementing complex
  ///   navigation logic, validation, or actions beyond simple URL navigation.
  /// </remarks>
  public string? OnAction { get; set; }

  /// <summary>
  ///   Gets or sets the custom image identifier for the hyperlink icon.
  /// </summary>
  /// <remarks>
  ///   The image identifier references a custom image resource included in the Office add-in.
  ///   The image appears next to the hyperlink label.
  /// </remarks>
  public string? Image { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office image identifier for the hyperlink icon.
  /// </summary>
  /// <remarks>
  ///   Use this to display a built-in Office icon next to the hyperlink label.
  /// </remarks>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's image.
  /// </summary>
  /// <remarks>
  ///   The callback function should return an image object or identifier.
  /// </remarks>
  public string? GetImage { get; set; }

  /// <summary>
  ///   Gets or sets the screentip (tooltip) text for the hyperlink.
  /// </summary>
  /// <remarks>
  ///   The screentip appears when the user hovers over the hyperlink, providing brief information
  ///   about the link destination or purpose.
  /// </remarks>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's screentip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the screentip.
  /// </remarks>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   Gets or sets the supertip (extended tooltip) text for the hyperlink.
  /// </summary>
  /// <remarks>
  ///   Supertips provide more detailed information than screentips, typically including a description
  ///   of what the user can expect when clicking the hyperlink.
  /// </remarks>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's supertip.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value for the supertip.
  /// </remarks>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   Gets or sets the target URL or location that the hyperlink navigates to when clicked.
  /// </summary>
  /// <remarks>
  ///   The target can be a web URL (http:// or https://), a file path (file:///), a mailto link (mailto:),
  ///   or other URI schemes supported by the operating system. When both <see cref="Target"/> and
  ///   <see cref="OnAction"/> are specified, the OnAction callback takes precedence.
  /// </remarks>
  public string? Target { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the hyperlink's target URL.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a string value containing the target URL or location.
  ///   This enables dynamic link destinations based on application state, user preferences, or other runtime conditions.
  /// </remarks>
  public string? GetTarget { get; set; }
}