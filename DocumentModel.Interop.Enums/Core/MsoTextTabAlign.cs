namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the text alignment against tab stops or line breaks. The default value is msoTabAlignLeft.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexttabalign?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextTabAlign")]
public enum TextTabAlign
{
  /// <summary>
  /// Specifies that mixed text alignment against tab stops is used.
  /// </summary>
  [InteropEnumValue("msoTabAlignMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies that the following text starts immediately after the designated tab stop.
  /// </summary>
  [InteropEnumValue("msoTabAlignLeft")]
  Left = 0,
  /// <summary>
  /// Specifies that the following text up to next tab or line break is centered on the designated tab stop.
  /// </summary>
  [InteropEnumValue("msoTabAlignCenter")]
  Center = 1,
  /// <summary>
  /// Specifies that the following text up to the next tab or line break is rendered flush right to the designated
  /// tab stop.
  /// </summary>
  [InteropEnumValue("msoTabAlignRight")]
  Right = 2,
  /// <summary>
  /// Specifies that the following text is searched for the first occurrence of the character representing the
  /// decimal point. The text up to the next tab or line break is then aligned such that the decimal point starts at
  /// the designated tab stop.
  /// </summary>
  [InteropEnumValue("msoTabAlignDecimal")]
  Decimal = 3
}
