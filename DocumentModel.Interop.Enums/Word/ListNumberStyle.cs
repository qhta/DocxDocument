namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeric style to apply to a list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdListNumberStyle")]
public enum ListNumberStyle
{
  /// <summary>
  /// Arabic numeric style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabic")]
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleUppercaseRoman")]
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLowercaseRoman")]
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleUppercaseLetter")]
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLowercaseLetter")]
  LowercaseLetter = 4,
  /// <summary>
  /// Ordinal style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleOrdinal")]
  Ordinal = 5,
  /// <summary>
  /// Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleCardinalText")]
  CardinalText = 6,
  /// <summary>
  /// Ordinal text style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleOrdinalText")]
  OrdinalText = 7,
  /// <summary>
  /// Kanji style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleKanji")]
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleKanjiDigit")]
  KanjiDigit = 11,
  /// <summary>
  /// Aiueo half-width numeric style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleAiueoHalfWidth")]
  AiueoHalfWidth = 12,
  /// <summary>
  /// Iroha half width style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleIrohaHalfWidth")]
  IrohaHalfWidth = 13,
  /// <summary>
  /// Arabic full-width numeric style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabicFullWidth")]
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleKanjiTraditional")]
  KanjiTraditional = 16,
  /// <summary>
  /// Kanji traditional 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleKanjiTraditional2")]
  KanjiTraditional2 = 17,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleNumberInCircle")]
  NumberInCircle = 18,
  /// <summary>
  /// Aiueo numeric style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleAiueo")]
  Aiueo = 20,
  /// <summary>
  /// Iroha style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleIroha")]
  Iroha = 21,
  /// <summary>
  /// 64
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabicLZ")]
  ArabicLZ = 22,
  /// <summary>
  /// Bullet style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleBullet")]
  Bullet = 23,
  /// <summary>
  /// Ganada style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleGanada")]
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleChosung")]
  Chosung = 25,
  /// <summary>
  /// GB numeric 1 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleGBNum1")]
  GBNum1 = 26,
  /// <summary>
  /// GB numeric 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleGBNum2")]
  GBNum2 = 27,
  /// <summary>
  /// GB numeric 3 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleGBNum3")]
  GBNum3 = 28,
  /// <summary>
  /// GB numeric 4 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleGBNum4")]
  GBNum4 = 29,
  /// <summary>
  /// Zodiac 1 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleZodiac1")]
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleZodiac2")]
  Zodiac2 = 31,
  /// <summary>
  /// Zodiac 3 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleZodiac3")]
  Zodiac3 = 32,
  /// <summary>
  /// Traditional Chinese numeric 1 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleTradChinNum1")]
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese numeric 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleTradChinNum2")]
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese numeric 3 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleTradChinNum3")]
  TradChinNum3 = 35,
  /// <summary>
  /// Traditional Chinese numeric 4 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleTradChinNum4")]
  TradChinNum4 = 36,
  /// <summary>
  /// Simplified Chinese numeric 1 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleSimpChinNum1")]
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese numeric 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleSimpChinNum2")]
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese numeric 3 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleSimpChinNum3")]
  SimpChinNum3 = 39,
  /// <summary>
  /// Simplified Chinese numeric 4 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleSimpChinNum4")]
  SimpChinNum4 = 40,
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHanjaRead")]
  HanjaRead = 41,
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHanjaReadDigit")]
  HanjaReadDigit = 42,
  /// <summary>
  /// Hanqul style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHangul")]
  Hangul = 43,
  /// <summary>
  /// Hanja style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHanja")]
  Hanja = 44,
  /// <summary>
  /// Hebrew 1 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHebrew1")]
  Hebrew1 = 45,
  /// <summary>
  /// Arabic 1 numeric style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabic1")]
  Arabic1 = 46,
  /// <summary>
  /// Hebrew 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHebrew2")]
  Hebrew2 = 47,
  /// <summary>
  /// Arabic 2 numeric style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabic2")]
  Arabic2 = 48,
  /// <summary>
  /// Hindi letter 1 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHindiLetter1")]
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter 2 style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHindiLetter2")]
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHindiArabic")]
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleHindiCardinalText")]
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleThaiLetter")]
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleThaiArabic")]
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleThaiCardinalText")]
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleVietCardinalText")]
  VietCardinalText = 56,
  /// <summary>
  /// Lowercase Russian style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLowercaseRussian")]
  LowercaseRussian = 58,
  /// <summary>
  /// Uppercase Russian style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleUppercaseRussian")]
  UppercaseRussian = 59,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLowercaseGreek")]
  LowercaseGreek = 60,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleUppercaseGreek")]
  UppercaseGreek = 61,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabicLZ2")]
  ArabicLZ2 = 62,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabicLZ3")]
  ArabicLZ3 = 63,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleArabicLZ4")]
  ArabicLZ4 = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLowercaseTurkish")]
  LowercaseTurkish = 65,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleUppercaseTurkish")]
  UppercaseTurkish = 66,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLowercaseBulgarian")]
  LowercaseBulgarian = 67,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleUppercaseBulgarian")]
  UppercaseBulgarian = 68,
  /// <summary>
  /// Picture bullet style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStylePictureBullet")]
  PictureBullet = 249,
  /// <summary>
  /// Legal style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLegal")]
  Legal = 253,
  /// <summary>
  /// Legal LZ style.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleLegalLZ")]
  LegalLZ = 254,
  /// <summary>
  /// No style applied.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleNone")]
  None = 255
}
