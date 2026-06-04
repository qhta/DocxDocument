namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to apply to endnotes, endnote options, footnotes, or footnote options.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnotenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdNoteNumberStyle")]
public enum NoteNumberStyle
{
  /// <summary>
  /// Arabic number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Symbol number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleSymbol")]
  Symbol = 9,
  /// <summary>
  /// Kanji number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji digit number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full-width number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Traditional Chinese number style 1.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleTradChinNum1")]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Simplified Chinese number style 1.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleSimpChinNum1")]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Hanja read number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHebrewLetter1")]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleArabicLetter1")]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHebrewLetter2")]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleArabicLetter2")]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic number style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleVietCardinalText")]
  VietCardinalText = 56
}
