namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to be used with the CaptionLabel object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCaptionNumberStyle")]
public enum CaptionNumberStyle
{
  /// <summary>
  /// Arabic style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase roman style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase roman style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji digit style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Full-width Arabic style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Ganada style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleGanada")]
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleChosung")]
  Chosung = 25,
  /// <summary>
  /// Zodiac style 1.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleZodiac1")]
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac style 2.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleZodiac2")]
  Zodiac2 = 31,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese number style 3.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleTradChinNum3")]
  TradChinNum3 = 35,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese number style 3.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleSimpChinNum3")]
  SimpChinNum3 = 39,
  /// <summary>
  /// Hanja read style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHebrewLetter1")]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleArabicLetter1")]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHebrewLetter2")]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleArabicLetter2")]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi cardinal style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai cardinal text style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese cardinal text style.
  /// </summary>
  [InteropEnumValue("wdCaptionNumberStyleVietCardinalText")]
  VietCardinalText = 56
}
