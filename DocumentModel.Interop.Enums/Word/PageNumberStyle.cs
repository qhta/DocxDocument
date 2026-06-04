namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style to apply to page numbers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPageNumberStyle")]
public enum PageNumberStyle
{
  /// <summary>
  /// Arabic style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full width style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Traditional Chinese number 1 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleTradChinNum1")]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese number 2 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Simplified Chinese number 1 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleSimpChinNum1")]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese number 2 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter 1 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHebrewLetter1")]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter 1 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleArabicLetter1")]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter 2 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHebrewLetter2")]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter 2 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleArabicLetter2")]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter 1 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter 2 style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal Text style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleVietCardinalText")]
  VietCardinalText = 56,
  /// <summary>
  /// Number in dash style.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleNumberInDash")]
  NumberInDash = 57
}
