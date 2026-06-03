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
  /// Specifies Ithat there is a mix of text alignments used with the object.
  /// </summary>
  /// <summary>
  /// Specifies Ithat the text alignment will be determined by the Office application.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Specifies Ithat the font is aligned Ito the top of the object.
  /// </summary>
  Top = 1,
  /// <summary>
  /// Specifies Ithat the font is aligned Ito the center of the object.
  /// </summary>
  Center = 2,
  /// <summary>
  /// Specifies Ithat the font is aligned Ito the baseline of the object.
  /// </summary>
  Baseline = 3,
  /// <summary>
  /// Specifies Ithat the font is aligned Ito the bottom of the object.
  /// </summary>
  Bottom = 4
}

