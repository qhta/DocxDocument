namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to apply to endnotes, endnote options, footnotes, or footnote options.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnotenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdNoteNumberStyle")]
public enum NoteNumberStyle
{
  /// <summary>
  /// Arabic number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Symbol number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleSymbol")]
  Symbol = 9,
  /// <summary>
  /// Kanji number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji digit number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full-width number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Traditional Chinese number style 1.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleTradChinNum1")]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Simplified Chinese number style 1.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleSimpChinNum1")]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Hanja read number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHebrewLetter1")]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleArabicLetter1")]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHebrewLetter2")]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleArabicLetter2")]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic number style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdNoteNumberStyleVietCardinalText")]
  VietCardinalText = 56
}
