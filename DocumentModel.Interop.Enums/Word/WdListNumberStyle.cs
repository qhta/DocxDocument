namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeric style to apply to a list.
/// </summary>
public enum WdListNumberStyle
{
  /// <summary>
  /// Arabic numeric style.
  /// </summary>
  Arabic = unchecked((int)0),
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  UppercaseRoman = unchecked((int)1),
  /// <summary>
  /// Lowercase Roman style.
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
  /// Ordinal style.
  /// </summary>
  Ordinal = unchecked((int)5),
  /// <summary>
  /// Cardinal text style.
  /// </summary>
  CardinalText = unchecked((int)6),
  /// <summary>
  /// Ordinal text style.
  /// </summary>
  OrdinalText = unchecked((int)7),
  /// <summary>
  /// Kanji style.
  /// </summary>
  Kanji = unchecked((int)10),
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  KanjiDigit = unchecked((int)11),
  /// <summary>
  /// Aiueo half-width numeric style. [System.Runtime.InteropServices.Guid("9C1DBE08-4499-311E-B83E-27B844624F91")]
  /// public enum WdListNumberStyle ﾉ Expand table
  /// </summary>
  AiueoHalfWidth = unchecked((int)12),
  /// <summary>
  /// Iroha half width style.
  /// </summary>
  IrohaHalfWidth = unchecked((int)13),
  /// <summary>
  /// Arabic full-width numeric style.
  /// </summary>
  ArabicFullWidth = unchecked((int)14),
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  KanjiTraditional = unchecked((int)16),
  /// <summary>
  /// Kanji
  /// </summary>
  KanjiTraditional2 = unchecked((int)17),
  /// <summary>
  /// Number in circle style.
  /// </summary>
  NumberInCircle = unchecked((int)18),
  /// <summary>
  /// Aiueo numeric style.
  /// </summary>
  Aiueo = unchecked((int)20),
  /// <summary>
  /// Iroha style.
  /// </summary>
  Iroha = unchecked((int)21),
  /// <summary>
  /// Arabic LZ numeric style.
  /// </summary>
  ArabicLZ = unchecked((int)22),
  /// <summary>
  /// Bullet style.
  /// </summary>
  Bullet = unchecked((int)23),
  /// <summary>
  /// Ganada style.
  /// </summary>
  Ganada = unchecked((int)24),
  /// <summary>
  /// Chosung style.
  /// </summary>
  Chosung = unchecked((int)25),
  /// <summary>
  /// GB
  /// </summary>
  GBNum1 = unchecked((int)26),
  /// <summary>
  /// GB
  /// </summary>
  GBNum2 = unchecked((int)27),
  /// <summary>
  /// GB
  /// </summary>
  GBNum3 = unchecked((int)28),
  /// <summary>
  /// GB
  /// </summary>
  GBNum4 = unchecked((int)29),
  /// <summary>
  /// Zodiac 1 style.
  /// </summary>
  Zodiac1 = unchecked((int)30),
  /// <summary>
  /// Zodiac 2 style.
  /// </summary>
  Zodiac2 = unchecked((int)31),
  /// <summary>
  /// Zodiac 3 style.
  /// </summary>
  Zodiac3 = unchecked((int)32),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum1 = unchecked((int)33),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum2 = unchecked((int)34),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum3 = unchecked((int)35),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  TradChinNum4 = unchecked((int)36),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum1 = unchecked((int)37),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum2 = unchecked((int)38),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum3 = unchecked((int)39),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  SimpChinNum4 = unchecked((int)40),
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  HanjaRead = unchecked((int)41),
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  HanjaReadDigit = unchecked((int)42),
  /// <summary>
  /// Hanqul style.
  /// </summary>
  Hangul = unchecked((int)43),
  /// <summary>
  /// Hanja style.
  /// </summary>
  Hanja = unchecked((int)44),
  /// <summary>
  /// Hebrew 1 style.
  /// </summary>
  Hebrew1 = unchecked((int)45),
  /// <summary>
  /// Arabic 1 numeric style.
  /// </summary>
  Arabic1 = unchecked((int)46),
  /// <summary>
  /// Hebrew 2 style.
  /// </summary>
  Hebrew2 = unchecked((int)47),
  /// <summary>
  /// Arabic 2 numeric style.
  /// </summary>
  Arabic2 = unchecked((int)48),
  /// <summary>
  /// Hindi
  /// </summary>
  HindiLetter1 = unchecked((int)49),
  /// <summary>
  /// Hindi
  /// </summary>
  HindiLetter2 = unchecked((int)50),
  /// <summary>
  /// Hindi Arabic style.
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
  /// Thai Arabic style.
  /// </summary>
  ThaiArabic = unchecked((int)54),
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  ThaiCardinalText = unchecked((int)55),
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  VietCardinalText = unchecked((int)56),
  /// <summary>
  /// Lowercase Russian style.
  /// </summary>
  LowercaseRussian = unchecked((int)58),
  /// <summary>
  /// Uppercase Russian style.
  /// </summary>
  UppercaseRussian = unchecked((int)59),
  /// <summary>
  /// wdListNumberStyleUppercaseGreek 61
  /// </summary>
  LowercaseGreek = unchecked((int)60),
  /// <summary>
  /// wdListNumberStyleArabicLZ2 62
  /// </summary>
  UppercaseGreek = unchecked((int)61),
  /// <summary>
  /// wdListNumberStyleArabicLZ3 63
  /// </summary>
  ArabicLZ2 = unchecked((int)62),
  /// <summary>
  /// wdListNumberStyleArabicLZ4 64
  /// </summary>
  ArabicLZ3 = unchecked((int)63),
  /// <summary>
  /// wdListNumberStyleLowercaseTurkish 65
  /// </summary>
  ArabicLZ4 = unchecked((int)64),
  /// <summary>
  /// wdListNumberStyleUppercaseTurkish 66
  /// </summary>
  LowercaseTurkish = unchecked((int)65),
  /// <summary>
  /// wdListNumberStyleLowercaseBulgarian 67
  /// </summary>
  UppercaseTurkish = unchecked((int)66),
  /// <summary>
  /// wdListNumberStyleUppercaseBulgarian 68
  /// </summary>
  LowercaseBulgarian = unchecked((int)67),
  /// <summary>
  /// wdListNumberStylePictureBullet 249 Picture bullet style.
  /// </summary>
  UppercaseBulgarian = unchecked((int)68),
  /// <summary>
  /// Picture bullet style.
  /// </summary>
  PictureBullet = unchecked((int)249),
  /// <summary>
  /// Legal style.
  /// </summary>
  Legal = unchecked((int)253),
  /// <summary>
  /// Legal LZ style.
  /// </summary>
  LegalLZ = unchecked((int)254),
  /// <summary>
  /// No style applied.
  /// </summary>
  None = unchecked((int)255)
}
