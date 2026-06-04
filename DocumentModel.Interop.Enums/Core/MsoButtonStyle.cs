namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of a command bar button.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoButtonStyle")]
public enum ButtonStyle
{
  /// <summary>
  /// Default behavior.
  /// </summary>
  [InteropEnumValue("msoButtonAutomatic")]
  Automatic = 0,
  /// <summary>
  /// Image only.
  /// </summary>
  [InteropEnumValue("msoButtonIcon")]
  Icon = 1,
  /// <summary>
  /// Text only.
  /// </summary>
  [InteropEnumValue("msoButtonCaption")]
  Caption = 2,
  /// <summary>
  /// Image and text, with text to the right of image.
  /// </summary>
  [InteropEnumValue("msoButtonIconAndCaption")]
  IconAndCaption = 3,
  /// <summary>
  /// Image with text wrapped and to the right of the image.
  /// </summary>
  [InteropEnumValue("msoButtonIconAndWrapCaption")]
  IconAndWrapCaption = 7,
  /// <summary>
  /// Image with text below.
  /// </summary>
  [InteropEnumValue("msoButtonIconAndCaptionBelow")]
  IconAndCaptionBelow = 11,
  /// <summary>
  /// Text only, centered and wrapped.
  /// </summary>
  [InteropEnumValue("msoButtonWrapCaption")]
  WrapCaption = 14,
  /// <summary>
  /// Image with text wrapped below image.
  /// </summary>
  [InteropEnumValue("msoButtonIconAndWrapCaptionBelow")]
  IconAndWrapCaptionBelow = 15
}
