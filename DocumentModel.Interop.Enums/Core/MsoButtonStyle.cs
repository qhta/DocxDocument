namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of a command bar button.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoButtonStyle
{
  /// <summary>
  /// Default behavior.
  /// </summary>
  Automatic = 0,
  /// <summary>
  /// Image only.
  /// </summary>
  Icon = 1,
  /// <summary>
  /// Text only.
  /// </summary>
  Caption = 2,
  /// <summary>
  /// Image and text, with text to the right of image. msoButtonIconAndWrapCaption7 Image with text wrapped and to
  /// the right of the image. msoButtonIconAndCaptionBelow11 Image with text below.
  /// </summary>
  IconAndCaption = 3,
  /// <summary>
  /// Specifies the style of a command bar button.
  /// </summary>
  IconAndWrapCaption = 7,
  /// <summary>
  /// Specifies the style of a command bar button.
  /// </summary>
  IconAndCaptionBelow = 11,
  /// <summary>
  /// Text only, centered and wrapped. msoButtonIconAndWrapCaptionBelow15 Image with text wrapped below image.
  /// </summary>
  WrapCaption = 14,
  /// <summary>
  /// Specifies the style of a command bar button.
  /// </summary>
  IconAndWrapCaptionBelow = 15
}
