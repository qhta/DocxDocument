namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number style to apply to endnotes, endnote options, footnotes, or footnote options.
/// </summary>
public enum WdNoteNumberStyle
{
  /// <summary>
  /// Arabic number style.
  /// </summary>
  Arabic = unchecked((int)0),
  /// <summary>
  /// Uppercase Roman number style.
  /// </summary>
  UppercaseRoman = unchecked((int)1),
  /// <summary>
  /// Lowercase Roman number style.
  /// </summary>
  LowercaseRoman = unchecked((int)2),
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  UppercaseLetter = unchecked((int)3),
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  LowercaseLetter = unchecked((int)4),
  /// <summary>
  /// Symbol number style.
  /// </summary>
  Symbol = unchecked((int)9),
  /// <summary>
  /// Kanji number style.
  /// </summary>
  Kanji = unchecked((int)10),
  /// <summary>
  /// Kanji digit number style.
  /// </summary>
  KanjiDigit = unchecked((int)11),
  /// <summary>
  /// Arabic full-width number style.
  /// </summary>
  ArabicFullWidth = unchecked((int)14),
  /// <summary>
  /// Kanji traditional number style. [System.Runtime.InteropServices.Guid("ACA7717A-16C6-370B-80DD-55F440008A67")]
  /// public enum WdNoteNumberStyle ﾉ Expand table
  /// </summary>
  KanjiTraditional = unchecked((int)16),
  /// <summary>
  /// Number in circle number style.
  /// </summary>
  NumberInCircle = unchecked((int)18),
  /// <summary>
  /// Traditional Chinese number style 1.
  /// </summary>
  TradChinNum1 = unchecked((int)33),
  /// <summary>
  /// Traditional Chinese number style 2.
  /// </summary>
  TradChinNum2 = unchecked((int)34),
  /// <summary>
  /// Simplified Chinese number style 1.
  /// </summary>
  SimpChinNum1 = unchecked((int)37),
  /// <summary>
  /// Simplified Chinese number style 2.
  /// </summary>
  SimpChinNum2 = unchecked((int)38),
  /// <summary>
  /// Hanja read number style.
  /// </summary>
  HanjaRead = unchecked((int)41),
  /// <summary>
  /// Hanja read digit number style.
  /// </summary>
  HanjaReadDigit = unchecked((int)42),
  /// <summary>
  /// Hebrew letter style 1.
  /// </summary>
  HebrewLetter1 = unchecked((int)45),
  /// <summary>
  /// Arabic letter style 1.
  /// </summary>
  ArabicLetter1 = unchecked((int)46),
  /// <summary>
  /// Hebrew letter style 2.
  /// </summary>
  HebrewLetter2 = unchecked((int)47),
  /// <summary>
  /// Arabic letter style 2.
  /// </summary>
  ArabicLetter2 = unchecked((int)48),
  /// <summary>
  /// Hindi letter style 1.
  /// </summary>
  HindiLetter1 = unchecked((int)49),
  /// <summary>
  /// Hindi letter style 2.
  /// </summary>
  HindiLetter2 = unchecked((int)50),
  /// <summary>
  /// Hindi Arabic number style.
  /// </summary>
  HindiArabic = unchecked((int)51),
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  HindiCardinalText = unchecked((int)52),
  /// <summary>
  /// Thai letter style.
  /// </summary>
  ThaiLetter = unchecked((int)53),
  /// <summary>
  /// Thai Arabic number style.
  /// </summary>
  ThaiArabic = unchecked((int)54),
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  ThaiCardinalText = unchecked((int)55),
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  VietCardinalText = unchecked((int)56)
}
