namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeric style to apply to a list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdListNumberStyle")]
public enum ListNumberStyle
{
  /// <summary>
  /// Arabic numeric style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Ordinal style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleOrdinal")]
  Ordinal = 5,
  /// <summary>
  /// Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleCardinalText")]
  CardinalText = 6,
  /// <summary>
  /// Ordinal text style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleOrdinalText")]
  OrdinalText = 7,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Aiueo half-width numeric style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleAiueoHalfWidth")]
  AiueoHalfWidth = 12,
  /// <summary>
  /// Iroha half width style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleIrohaHalfWidth")]
  IrohaHalfWidth = 13,
  /// <summary>
  /// Arabic full-width numeric style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Kanji traditional 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleKanjiTraditional2")]
  KanjiTraditional2 = 17,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Aiueo numeric style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleAiueo")]
  Aiueo = 20,
  /// <summary>
  /// Iroha style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleIroha")]
  Iroha = 21,
  /// <summary>
  /// 64
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabicLZ")]
  ArabicLZ = 22,
  /// <summary>
  /// Bullet style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleBullet")]
  Bullet = 23,
  /// <summary>
  /// Ganada style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleGanada")]
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleChosung")]
  Chosung = 25,
  /// <summary>
  /// GB numeric 1 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleGBNum1")]
  GBNum1 = 26,
  /// <summary>
  /// GB numeric 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleGBNum2")]
  GBNum2 = 27,
  /// <summary>
  /// GB numeric 3 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleGBNum3")]
  GBNum3 = 28,
  /// <summary>
  /// GB numeric 4 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleGBNum4")]
  GBNum4 = 29,
  /// <summary>
  /// Zodiac 1 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleZodiac1")]
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleZodiac2")]
  Zodiac2 = 31,
  /// <summary>
  /// Zodiac 3 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleZodiac3")]
  Zodiac3 = 32,
  /// <summary>
  /// Traditional Chinese numeric 1 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleTradChinNum1")]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese numeric 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese numeric 3 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleTradChinNum3")]
  TradChinNum3 = 35,
  /// <summary>
  /// Traditional Chinese numeric 4 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleTradChinNum4")]
  TradChinNum4 = 36,
  /// <summary>
  /// Simplified Chinese numeric 1 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleSimpChinNum1")]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese numeric 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese numeric 3 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleSimpChinNum3")]
  SimpChinNum3 = 39,
  /// <summary>
  /// Simplified Chinese numeric 4 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleSimpChinNum4")]
  SimpChinNum4 = 40,
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hanqul style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHangul")]
  Hangul = 43,
  /// <summary>
  /// Hanja style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHanja")]
  Hanja = 44,
  /// <summary>
  /// Hebrew 1 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHebrew1")]
  Hebrew1 = 45,
  /// <summary>
  /// Arabic 1 numeric style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabic1")]
  Arabic1 = 46,
  /// <summary>
  /// Hebrew 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHebrew2")]
  Hebrew2 = 47,
  /// <summary>
  /// Arabic 2 numeric style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabic2")]
  Arabic2 = 48,
  /// <summary>
  /// Hindi letter 1 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter 2 style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleVietCardinalText")]
  VietCardinalText = 56,
  /// <summary>
  /// Lowercase Russian style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLowercaseRussian")]
  LowercaseRussian = 58,
  /// <summary>
  /// Uppercase Russian style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleUppercaseRussian")]
  UppercaseRussian = 59,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLowercaseGreek")]
  LowercaseGreek = 60,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleUppercaseGreek")]
  UppercaseGreek = 61,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabicLZ2")]
  ArabicLZ2 = 62,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabicLZ3")]
  ArabicLZ3 = 63,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleArabicLZ4")]
  ArabicLZ4 = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLowercaseTurkish")]
  LowercaseTurkish = 65,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleUppercaseTurkish")]
  UppercaseTurkish = 66,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLowercaseBulgarian")]
  LowercaseBulgarian = 67,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleUppercaseBulgarian")]
  UppercaseBulgarian = 68,
  /// <summary>
  /// Picture bullet style.
  /// </summary>
  [InteropEnumValue("wdListNumberStylePictureBullet")]
  PictureBullet = 249,
  /// <summary>
  /// Legal style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLegal")]
  Legal = 253,
  /// <summary>
  /// Legal LZ style.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleLegalLZ")]
  LegalLZ = 254,
  /// <summary>
  /// No style applied.
  /// </summary>
  [InteropEnumValue("wdListNumberStyleNone")]
  None = 255
}
