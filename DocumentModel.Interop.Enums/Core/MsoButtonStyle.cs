namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of a command bar button.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoButtonStyle")]
public enum ButtonStyle
{
  /// <summary>
  /// Default behavior.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonAutomatic")]
  Automatic = 0,
  /// <summary>
  /// Image only.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonIcon")]
  Icon = 1,
  /// <summary>
  /// Text only.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonCaption")]
  Caption = 2,
  /// <summary>
  /// Image and text, with text to the right of image.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonIconAndCaption")]
  IconAndCaption = 3,
  /// <summary>
  /// Image with text wrapped and to the right of the image.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonIconAndWrapCaption")]
  IconAndWrapCaption = 7,
  /// <summary>
  /// Image with text below.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonIconAndCaptionBelow")]
  IconAndCaptionBelow = 11,
  /// <summary>
  /// Text only, centered and wrapped.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonWrapCaption")]
  WrapCaption = 14,
  /// <summary>
  /// Image with text wrapped below image.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonIconAndWrapCaptionBelow")]
  IconAndWrapCaptionBelow = 15
}
