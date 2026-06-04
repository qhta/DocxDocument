namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the text alignment scheme used for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextfontalign?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextFontAlign))]
public enum TextFontAlign
{
  /// <summary>
  /// Specifies that there is a mix of text alignments used with the object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextFontAlign.msoFontAlignMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies that the text alignment will be determined by the Office application.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextFontAlign.msoFontAlignAuto))]
  Auto = 0,
  /// <summary>
  /// Specifies that the font is aligned to the top of the object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextFontAlign.msoFontAlignTop))]
  Top = 1,
  /// <summary>
  /// Specifies that the font is aligned to the center of the object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextFontAlign.msoFontAlignCenter))]
  Center = 2,
  /// <summary>
  /// Specifies that the font is aligned to the baseline of the object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextFontAlign.msoFontAlignBaseline))]
  Baseline = 3,
  /// <summary>
  /// Specifies that the font is aligned to the bottom of the object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextFontAlign.msoFontAlignBottom))]
  Bottom = 4
}
