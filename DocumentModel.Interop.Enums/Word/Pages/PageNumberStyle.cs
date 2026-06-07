namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style to apply to page numbers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPageNumberStyle")]
public enum PageNumberStyle
{
  /// <summary>
  /// Arabic style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full width style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Traditional Chinese number 1 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleTradChinNum1")]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese number 2 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Simplified Chinese number 1 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleSimpChinNum1")]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese number 2 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter 1 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHebrewLetter1")]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter 1 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleArabicLetter1")]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter 2 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHebrewLetter2")]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter 2 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleArabicLetter2")]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter 1 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter 2 style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal Text style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleVietCardinalText")]
  VietCardinalText = 56,
  /// <summary>
  /// Number in dash style.
  /// </summary>
  [InteropEnumValue("wdPageNumberStyleNumberInDash")]
  NumberInDash = 57
}
