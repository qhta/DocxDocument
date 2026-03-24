namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style to apply to page numbers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdPageNumberStyle
{
  /// <summary>
  /// Arabic style.
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
  /// Kanji style.
  /// </summary>
  Kanji = 10,
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  KanjiDigit = 11,
  /// <summary>
  /// Arabic full width style.
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
  /// Traditional Chinese number 1 style.
  /// </summary>
  TradChinNum1 = 33,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  TradChinNum2 = 34,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  SimpChinNum1 = 37,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  SimpChinNum2 = 38,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HanjaRead = 41,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HanjaReadDigit = 42,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HebrewLetter1 = 45,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  ArabicLetter1 = 46,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HebrewLetter2 = 47,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  ArabicLetter2 = 48,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HindiLetter1 = 49,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HindiLetter2 = 50,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HindiArabic = 51,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  HindiCardinalText = 52,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  ThaiLetter = 53,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  ThaiArabic = 54,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  ThaiCardinalText = 55,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  VietCardinalText = 56,
  /// <summary>
  /// Specifies the style to apply to page numbers.
  /// </summary>
  NumberInDash = 57
}
