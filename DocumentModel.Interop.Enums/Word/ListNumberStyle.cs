namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeric style to apply to a list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdListNumberStyle))]
public enum ListNumberStyle
{
  /// <summary>
  /// Arabic numeric style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabic))]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleUppercaseRoman))]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLowercaseRoman))]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleUppercaseLetter))]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLowercaseLetter))]
  LowercaseLetter = 4,
  /// <summary>
  /// Ordinal style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleOrdinal))]
  Ordinal = 5,
  /// <summary>
  /// Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleCardinalText))]
  CardinalText = 6,
  /// <summary>
  /// Ordinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleOrdinalText))]
  OrdinalText = 7,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleKanji))]
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleKanjiDigit))]
  KanjiDigit = 11,
  /// <summary>
  /// Aiueo half-width numeric style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleAiueoHalfWidth))]
  AiueoHalfWidth = 12,
  /// <summary>
  /// Iroha half width style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleIrohaHalfWidth))]
  IrohaHalfWidth = 13,
  /// <summary>
  /// Arabic full-width numeric style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabicFullWidth))]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleKanjiTraditional))]
  KanjiTraditional = 16,
  /// <summary>
  /// Kanji traditional 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleKanjiTraditional2))]
  KanjiTraditional2 = 17,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleNumberInCircle))]
  NumberInCircle = 18,
  /// <summary>
  /// Aiueo numeric style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleAiueo))]
  Aiueo = 20,
  /// <summary>
  /// Iroha style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleIroha))]
  Iroha = 21,
  /// <summary>
  /// 64
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabicLZ))]
  ArabicLZ = 22,
  /// <summary>
  /// Bullet style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleBullet))]
  Bullet = 23,
  /// <summary>
  /// Ganada style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleGanada))]
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleChosung))]
  Chosung = 25,
  /// <summary>
  /// GB numeric 1 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleGBNum1))]
  GBNum1 = 26,
  /// <summary>
  /// GB numeric 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleGBNum2))]
  GBNum2 = 27,
  /// <summary>
  /// GB numeric 3 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleGBNum3))]
  GBNum3 = 28,
  /// <summary>
  /// GB numeric 4 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleGBNum4))]
  GBNum4 = 29,
  /// <summary>
  /// Zodiac 1 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleZodiac1))]
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleZodiac2))]
  Zodiac2 = 31,
  /// <summary>
  /// Zodiac 3 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleZodiac3))]
  Zodiac3 = 32,
  /// <summary>
  /// Traditional Chinese numeric 1 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleTradChinNum1))]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese numeric 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleTradChinNum2))]
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese numeric 3 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleTradChinNum3))]
  TradChinNum3 = 35,
  /// <summary>
  /// Traditional Chinese numeric 4 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleTradChinNum4))]
  TradChinNum4 = 36,
  /// <summary>
  /// Simplified Chinese numeric 1 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleSimpChinNum1))]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese numeric 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleSimpChinNum2))]
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese numeric 3 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleSimpChinNum3))]
  SimpChinNum3 = 39,
  /// <summary>
  /// Simplified Chinese numeric 4 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleSimpChinNum4))]
  SimpChinNum4 = 40,
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHanjaRead))]
  HanjaRead = 41,
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHanjaReadDigit))]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hanqul style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHangul))]
  Hangul = 43,
  /// <summary>
  /// Hanja style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHanja))]
  Hanja = 44,
  /// <summary>
  /// Hebrew 1 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHebrew1))]
  Hebrew1 = 45,
  /// <summary>
  /// Arabic 1 numeric style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabic1))]
  Arabic1 = 46,
  /// <summary>
  /// Hebrew 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHebrew2))]
  Hebrew2 = 47,
  /// <summary>
  /// Arabic 2 numeric style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabic2))]
  Arabic2 = 48,
  /// <summary>
  /// Hindi letter 1 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHindiLetter1))]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter 2 style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHindiLetter2))]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHindiArabic))]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleHindiCardinalText))]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleThaiLetter))]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleThaiArabic))]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleThaiCardinalText))]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleVietCardinalText))]
  VietCardinalText = 56,
  /// <summary>
  /// Lowercase Russian style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLowercaseRussian))]
  LowercaseRussian = 58,
  /// <summary>
  /// Uppercase Russian style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleUppercaseRussian))]
  UppercaseRussian = 59,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLowercaseGreek))]
  LowercaseGreek = 60,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleUppercaseGreek))]
  UppercaseGreek = 61,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabicLZ2))]
  ArabicLZ2 = 62,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabicLZ3))]
  ArabicLZ3 = 63,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleArabicLZ4))]
  ArabicLZ4 = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLowercaseTurkish))]
  LowercaseTurkish = 65,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleUppercaseTurkish))]
  UppercaseTurkish = 66,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLowercaseBulgarian))]
  LowercaseBulgarian = 67,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleUppercaseBulgarian))]
  UppercaseBulgarian = 68,
  /// <summary>
  /// Picture bullet style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStylePictureBullet))]
  PictureBullet = 249,
  /// <summary>
  /// Legal style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLegal))]
  Legal = 253,
  /// <summary>
  /// Legal LZ style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleLegalLZ))]
  LegalLZ = 254,
  /// <summary>
  /// No style applied.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListNumberStyle.wdListNumberStyleNone))]
  None = 255
}
