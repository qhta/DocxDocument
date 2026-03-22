namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeral style for an Arabic-language document.
/// </summary>
public enum WdArabicNumeral
{
  /// <summary>
  /// Arabic shape is used for numerals.
  /// </summary>
  wdNumeralArabic = unchecked((int)0),
  /// <summary>
  /// Hindi shape is used for numerals.
  /// </summary>
  wdNumeralHindi = unchecked((int)1),
  /// <summary>
  /// Numeral shape depends on text surrounding it.
  /// </summary>
  wdNumeralContext = unchecked((int)2),
  /// <summary>
  /// Numeral shape is determined by system settings.
  /// </summary>
  wdNumeralSystem = unchecked((int)3)
}
