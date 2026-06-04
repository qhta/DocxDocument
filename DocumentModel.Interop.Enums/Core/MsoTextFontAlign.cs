namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the text alignment scheme used for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextfontalign?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextFontAlign")]
public enum TextFontAlign
{
  /// <summary>
  /// Specifies that there is a mix of text alignments used with the object.
  /// </summary>
  [InteropEnumValue("msoFontAlignMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies that the text alignment will be determined by the Office application.
  /// </summary>
  [InteropEnumValue("msoFontAlignAuto")]
  Auto = 0,
  /// <summary>
  /// Specifies that the font is aligned to the top of the object.
  /// </summary>
  [InteropEnumValue("msoFontAlignTop")]
  Top = 1,
  /// <summary>
  /// Specifies that the font is aligned to the center of the object.
  /// </summary>
  [InteropEnumValue("msoFontAlignCenter")]
  Center = 2,
  /// <summary>
  /// Specifies that the font is aligned to the baseline of the object.
  /// </summary>
  [InteropEnumValue("msoFontAlignBaseline")]
  Baseline = 3,
  /// <summary>
  /// Specifies that the font is aligned to the bottom of the object.
  /// </summary>
  [InteropEnumValue("msoFontAlignBottom")]
  Bottom = 4
}
