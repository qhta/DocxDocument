namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to be used with the CaptionLabel object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle))]
public enum CaptionNumberStyle
{
  /// <summary>
  /// Arabic style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleArabic))]
  Arabic = 0,
  /// <summary>
  /// Uppercase roman style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleUppercaseRoman))]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase roman style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleLowercaseRoman))]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleUppercaseLetter))]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleLowercaseLetter))]
  LowercaseLetter = 4,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleKanji))]
  Kanji = 10,
  /// <summary>
  /// Kanji digit style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleKanjiDigit))]
  KanjiDigit = 11,
  /// <summary>
  /// Full-width Arabic style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleArabicFullWidth))]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleKanjiTraditional))]
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleNumberInCircle))]
  NumberInCircle = 18,
  /// <summary>
  /// Ganada style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleGanada))]
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleChosung))]
  Chosung = 25,
  /// <summary>
  /// Zodiac style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleZodiac1))]
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleZodiac2))]
  Zodiac2 = 31,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleTradChinNum2))]
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese number style 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleTradChinNum3))]
  TradChinNum3 = 35,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleSimpChinNum2))]
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese number style 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleSimpChinNum3))]
  SimpChinNum3 = 39,
  /// <summary>
  /// Hanja read style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHanjaRead))]
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHanjaReadDigit))]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHebrewLetter1))]
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleArabicLetter1))]
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHebrewLetter2))]
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleArabicLetter2))]
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHindiLetter1))]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHindiLetter2))]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHindiArabic))]
  HindiArabic = 51,
  /// <summary>
  /// Hindi cardinal style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleHindiCardinalText))]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleThaiLetter))]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleThaiArabic))]
  ThaiArabic = 54,
  /// <summary>
  /// Thai cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleThaiCardinalText))]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionNumberStyle.wdCaptionNumberStyleVietCardinalText))]
  VietCardinalText = 56
}
