namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to be used with the CaptionLabel object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionnumberstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum ExtendedNumberStyle
{
  /// <summary>
  /// Arabic style.
  /// </summary>
  Arabic = 0,
  /// <summary>
  /// Uppercase roman style.
  /// </summary>
  UppercaseRoman = 1,
  /// <summary>
  /// Lowercase roman style.
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
  /// Kanji style.
  /// </summary>
  Kanji = 10,
  /// <summary>
  /// Kanji digit style.
  /// </summary>
  KanjiDigit = 11,
  /// <summary>
  /// Full-width Arabic style.
  /// </summary>
  ArabicFullWidth = 14,
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  KanjiTraditional = 16,
  /// <summary>
  /// Number in circle style.
  /// </summary>
  NumberInCircle = 18,
  /// <summary>
  /// Ganada style.
  /// </summary>
  Ganada = 24,
  /// <summary>
  /// Chosung style.
  /// </summary>
  Chosung = 25,
  /// <summary>
  /// Zodiac style 1.
  /// </summary>
  Zodiac1 = 30,
  /// <summary>
  /// Zodiac style 2.
  /// </summary>
  Zodiac2 = 31,
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  TradChinNum2 = 34,
  /// <summary>
  /// Traditional Chinese number style 3.
  /// </summary>
  TradChinNum3 = 35,
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  SimpChinNum2 = 38,
  /// <summary>
  /// Simplified Chinese number style 3.
  /// </summary>
  SimpChinNum3 = 39,
  /// <summary>
  /// Hanja read style.
  /// </summary>
  HanjaRead = 41,
  /// <summary>
  /// Hanja read digit style.
  /// </summary>
  HanjaReadDigit = 42,
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  HebrewLetter1 = 45,
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  ArabicLetter1 = 46,
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  HebrewLetter2 = 47,
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  ArabicLetter2 = 48,
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  HindiLetter1 = 49,
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  HindiLetter2 = 50,
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  HindiArabic = 51,
  /// <summary>
  /// Hindi cardinal style.
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
  /// Thai cardinal text style.
  /// </summary>
  ThaiCardinalText = 55,
  /// <summary>
  /// Vietnamese cardinal text style.
  /// </summary>
  VietCardinalText = 56
}
