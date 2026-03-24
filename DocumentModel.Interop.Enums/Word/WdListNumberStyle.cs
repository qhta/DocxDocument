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
  /// Aiueo half-width numeric style.
  /// </summary>
  AiueoHalfWidth = 12,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  IrohaHalfWidth = 13,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ArabicFullWidth = 14,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  KanjiTraditional = 16,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  KanjiTraditional2 = 17,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  NumberInCircle = 18,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Aiueo = 20,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Iroha = 21,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ArabicLZ = 22,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Bullet = 23,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Ganada = 24,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Chosung = 25,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  GBNum1 = 26,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  GBNum2 = 27,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  GBNum3 = 28,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  GBNum4 = 29,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Zodiac1 = 30,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Zodiac2 = 31,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Zodiac3 = 32,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  TradChinNum1 = 33,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  TradChinNum2 = 34,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  TradChinNum3 = 35,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  TradChinNum4 = 36,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  SimpChinNum1 = 37,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  SimpChinNum2 = 38,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  SimpChinNum3 = 39,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  SimpChinNum4 = 40,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  HanjaRead = 41,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  HanjaReadDigit = 42,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Hangul = 43,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Hanja = 44,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Hebrew1 = 45,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Arabic1 = 46,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Hebrew2 = 47,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Arabic2 = 48,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  HindiLetter1 = 49,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  HindiLetter2 = 50,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  HindiArabic = 51,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  HindiCardinalText = 52,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ThaiLetter = 53,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ThaiArabic = 54,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ThaiCardinalText = 55,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  VietCardinalText = 56,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  LowercaseRussian = 58,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  UppercaseRussian = 59,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  LowercaseGreek = 60,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  UppercaseGreek = 61,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ArabicLZ2 = 62,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ArabicLZ3 = 63,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  ArabicLZ4 = 64,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  LowercaseTurkish = 65,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  UppercaseTurkish = 66,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  LowercaseBulgarian = 67,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  UppercaseBulgarian = 68,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  PictureBullet = 249,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  Legal = 253,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  LegalLZ = 254,
  /// <summary>
  /// Specifies the numeric style to apply to a list.
  /// </summary>
  None = 255
}
