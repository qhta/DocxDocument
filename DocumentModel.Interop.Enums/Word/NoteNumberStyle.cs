namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to apply to endnotes, endnote options, footnotes, or footnote options.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnotenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdNoteNumberStyle))]
public enum NoteNumberStyle
{
  /// <summary>
  /// Arabic number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleArabic))]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleUppercaseRoman))]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleLowercaseRoman))]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleUppercaseLetter))]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleLowercaseLetter))]
  LowercaseLetter = 4,
  /// <summary>
  /// Symbol number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleSymbol))]
  Symbol = 9,
  /// <summary>
  /// Kanji number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleKanji))]
  Kanji = 10,
  /// <summary>
  /// Kanji digit number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleKanjiDigit))]
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full-width number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleArabicFullWidth))]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleKanjiTraditional))]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleNumberInCircle))]
  NumberInCircle = 18,
  /// <summary>
  /// Traditional Chinese number style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleTradChinNum1))]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleTradChinNum2))]
  TradChinNum2 = 34,
  /// <summary>
  /// Simplified Chinese number style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleSimpChinNum1))]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleSimpChinNum2))]
  SimpChinNum2 = 38,
  /// <summary>
  /// Hanja read number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHanjaRead))]
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHanjaReadDigit))]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHebrewLetter1))]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleArabicLetter1))]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHebrewLetter2))]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleArabicLetter2))]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHindiLetter1))]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHindiLetter2))]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHindiArabic))]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleHindiCardinalText))]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleThaiLetter))]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic number style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleThaiArabic))]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleThaiCardinalText))]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNoteNumberStyle.wdNoteNumberStyleVietCardinalText))]
  VietCardinalText = 56
}
