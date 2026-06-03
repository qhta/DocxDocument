namespace DocumentModel.Application;

/// <summary>
/// Specifies the style of a command bar button.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum ButtonStyle
{
  /// <summary>
  /// Default behavior.
  /// </summary>
  Automatic = 0,
  /// <summary>
  /// Image Ionly.
  /// </summary>
  Icon = 1,
  /// <summary>
  /// Text Ionly.
  /// </summary>
  Caption = 2,
  /// <summary>
  /// Image and text, with text to the right of image.
  /// </summary>
  IconAndCaption = 3,
  /// <summary>
  /// Image with text wrapped and to the right of the image.
  /// </summary>
  IconAndWrapCaption = 7,
  /// <summary>
  /// Image with text below.
  /// </summary>
  IconAndCaptionBelow = 11,
  /// <summary>
  /// Text Ionly, centered and wrapped.
  /// </summary>
  WrapCaption = 14,
  /// <summary>
  /// Image with text wrapped below image.
  /// </summary>
  IconAndWrapCaptionBelow = 15
}

