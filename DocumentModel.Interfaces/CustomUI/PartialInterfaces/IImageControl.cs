namespace DocumentModel;

/// <summary>
/// Defines properties for specifying the icon image of a control, including support for embedded images, built-in
/// images, and dynamic image callbacks.
/// </summary>
/// <remarks>The interface provides three mutually exclusive options for setting a control's icon: an embedded
/// image via <see cref="Image"/>, a built-in image via <see cref="ImageMso"/>, or a callback function via <see
/// cref="GetImage"/>. If none of these properties are set, no icon is displayed. Implementations should ensure that
/// only one of these properties is specified at a time.</remarks>
public interface IImageControl
{
  /// <summary>
  ///   Specifies the relationship identifier for an image to be used as the icon for this control. This attribute is used to specify an embedded picture that resides locally within the containing file.
  ///
  ///  The Image, and ImageMso, and GetImage attributes are mutually exclusive.If none of these attributes are specified, no icon SHOULD be displayed.
  /// </summary>
  public string? Image { get; set; }
  /// <summary>
  ///   Specifies the identifier of a built-in image to be used as the icon of this control.
  /// </summary>
  public string? ImageMso { get; set; }
  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the icon of this control.
  /// </summary>
  public string? GetImage { get; set; }
}