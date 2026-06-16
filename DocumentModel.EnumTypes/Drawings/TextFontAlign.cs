namespace DocumentModel.Drawings;

/// <summary>
/// Indicates the text alignment scheme used for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextfontalign?view=office-pia` for Office interop details.
/// </remarks>
public enum TextFontAlign
{
  /// <summary>
  /// Specifies that there is a mix of text alignments used with the object.
  /// </summary>
  /// <summary>
  /// Specifies that the text alignment will be determined by the Office application.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Specifies that the font is aligned to the top of the object.
  /// </summary>
  Top = 1,
  /// <summary>
  /// Specifies that the font is aligned to the center of the object.
  /// </summary>
  Center = 2,
  /// <summary>
  /// Specifies that the font is aligned to the baseline of the object.
  /// </summary>
  Baseline = 3,
  /// <summary>
  /// Specifies that the font is aligned to the bottom of the object.
  /// </summary>
  Bottom = 4
}

