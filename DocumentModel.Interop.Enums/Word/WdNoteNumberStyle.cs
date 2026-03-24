namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to apply to endnotes, endnote options, footnotes, or footnote options.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnotenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdNoteNumberStyle
{
  /// <summary>
  /// Arabic number style.
  /// </summary>
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman number style.
  /// </summary>
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman number style.
  /// </summary>
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  LowercaseLetter = 4,
  /// <summary>
  /// Symbol number style.
  /// </summary>
  Symbol = 9,
  /// <summary>
  /// Kanji number style.
  /// </summary>
  Kanji = 10,
  /// <summary>
  /// Kanji digit number style.
  /// </summary>
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full-width number style.
  /// </summary>
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional number style. [System.Runtime.InteropServices.Guid("ACA7717A-16C6-370B-80DD-55F440008A67")]
  /// public enum WdNoteNumberStyle ﾉ Expand table
  /// </summary>
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle number style.
  /// </summary>
  NumberInCircle = 18,
  /// <summary>
  /// Traditional Chinese number style 1.
  /// </summary>
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  TradChinNum2 = 34,
  /// <summary>
  /// Simplified Chinese number style 1.
  /// </summary>
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  SimpChinNum2 = 38,
  /// <summary>
  /// Hanja read number style.
  /// </summary>
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit number style.
  /// </summary>
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic number style.
  /// </summary>
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic number style.
  /// </summary>
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  VietCardinalText = 56
}
