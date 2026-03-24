namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeric style to apply to a list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdListNumberStyle
{
  /// <summary>
  /// Arabic numeric style.
  /// </summary>
  Arabic = 0,
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  LowercaseRoman = 2,
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  UppercaseLetter = 3,
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  LowercaseLetter = 4,
  /// <summary>
  /// Ordinal style.
  /// </summary>
  Ordinal = 5,
  /// <summary>
  /// Cardinal text style.
  /// </summary>
  CardinalText = 6,
  /// <summary>
  /// Ordinal text style.
  /// </summary>
  OrdinalText = 7,
  /// <summary>
  /// Kanji style.
  /// </summary>
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  KanjiDigit = 11,
  /// <summary>
  /// Aiueo half-width numeric style. [System.Runtime.InteropServices.Guid("9C1DBE08-4499-311E-B83E-27B844624F91")]
  /// public enum WdListNumberStyle ﾉ Expand table
  /// </summary>
  AiueoHalfWidth = 12,
  /// <summary>
  /// Iroha half width style.
  /// </summary>
  IrohaHalfWidth = 13,
  /// <summary>
  /// Arabic full-width numeric style.
  /// </summary>
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  KanjiTraditional = 16,
  /// <summary>
  /// Kanji
  /// </summary>
  KanjiTraditional2 = 17,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  NumberInCircle = 18,
  /// <summary>
  /// Aiueo numeric style.
  /// </summary>
  Aiueo = 20,
  /// <summary>
  /// Iroha style.
  /// </summary>
  Iroha = 21,
  /// <summary>
  /// Arabic LZ numeric style.
  /// </summary>
  ArabicLZ = 22,
  /// <summary>
  /// Bullet style.
  /// </summary>
  Bullet = 23,
  /// <summary>
  /// Ganada style.
  /// </summary>
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  Chosung = 25,
  /// <summary>
  /// GB
  /// </summary>
  GBNum1 = 26,
  /// <summary>
  /// GB
  /// </summary>
  GBNum2 = 27,
  /// <summary>
  /// GB
  /// </summary>
  GBNum3 = 28,
  /// <summary>
  /// GB
  /// </summary>
  GBNum4 = 29,
  /// <summary>
  /// Zodiac 1 style.
  /// </summary>
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac 2 style.
  /// </summary>
  Zodiac2 = 31,
  /// <summary>
  /// Zodiac 3 style.
  /// </summary>
  Zodiac3 = 32,
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum1 = 33,
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum3 = 35,
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum4 = 36,
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum1 = 37,
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum3 = 39,
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum4 = 40,
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  HanjaRead = 41,
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  HanjaReadDigit = 42,
  /// <summary>
  /// Hanqul style.
  /// </summary>
  Hangul = 43,
  /// <summary>
  /// Hanja style.
  /// </summary>
  Hanja = 44,
  /// <summary>
  /// Hebrew 1 style.
  /// </summary>
  Hebrew1 = 45,
  /// <summary>
  /// Arabic 1 numeric style.
  /// </summary>
  Arabic1 = 46,
  /// <summary>
  /// Hebrew 2 style.
  /// </summary>
  Hebrew2 = 47,
  /// <summary>
  /// Arabic 2 numeric style.
  /// </summary>
  Arabic2 = 48,
  /// <summary>
  /// Hindi
  /// </summary>
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi
  /// </summary>
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  HindiArabic = 51,
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  HindiCardinalText = 52,
  /// <summary>
  /// Thai letter style.
  /// </summary>
  ThaiLetter = 53,
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  ThaiArabic = 54,
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  VietCardinalText = 56,
  /// <summary>
  /// Lowercase Russian style.
  /// </summary>
  LowercaseRussian = 58,
  /// <summary>
  /// Uppercase Russian style.
  /// </summary>
  UppercaseRussian = 59,
  /// <summary>
  /// wdListNumberStyleUppercaseGreek 61
  /// </summary>
  LowercaseGreek = 60,
  /// <summary>
  /// wdListNumberStyleArabicLZ2 62
  /// </summary>
  UppercaseGreek = 61,
  /// <summary>
  /// wdListNumberStyleArabicLZ3 63
  /// </summary>
  ArabicLZ2 = 62,
  /// <summary>
  /// wdListNumberStyleArabicLZ4 64
  /// </summary>
  ArabicLZ3 = 63,
  /// <summary>
  /// wdListNumberStyleLowercaseTurkish 65
  /// </summary>
  ArabicLZ4 = 64,
  /// <summary>
  /// wdListNumberStyleUppercaseTurkish 66
  /// </summary>
  LowercaseTurkish = 65,
  /// <summary>
  /// wdListNumberStyleLowercaseBulgarian 67
  /// </summary>
  UppercaseTurkish = 66,
  /// <summary>
  /// wdListNumberStyleUppercaseBulgarian 68
  /// </summary>
  LowercaseBulgarian = 67,
  /// <summary>
  /// wdListNumberStylePictureBullet 249 Picture bullet style.
  /// </summary>
  UppercaseBulgarian = 68,
  /// <summary>
  /// Picture bullet style.
  /// </summary>
  PictureBullet = 249,
  /// <summary>
  /// Legal style.
  /// </summary>
  Legal = 253,
  /// <summary>
  /// Legal LZ style.
  /// </summary>
  LegalLZ = 254,
  /// <summary>
  /// No style applied.
  /// </summary>
  None = 255
}
