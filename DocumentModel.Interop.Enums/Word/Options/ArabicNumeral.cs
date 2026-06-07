namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeral style for an Arabic-language document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdarabicnumeral?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdArabicNumeral")]
public enum ArabicNumeral
{
  /// <summary>
  /// Arabic shape is used for numerals.
  /// </summary>
  [InteropEnumValue("wdNumeralArabic")]
  Arabic = 0,
  /// <summary>
  /// Hindi shape is used for numerals.
  /// </summary>
  [InteropEnumValue("wdNumeralHindi")]
  Hindi = 1,
  /// <summary>
  /// Numeral shape depends on text surrounding it.
  /// </summary>
  [InteropEnumValue("wdNumeralContext")]
  Context = 2,
  /// <summary>
  /// Numeral shape is determined by system settings.
  /// </summary>
  [InteropEnumValue("wdNumeralSystem")]
  System = 3
}
