namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeric style to apply to a list.
/// </summary>
public enum WdListNumberStyle
{
  /// <summary>
  /// Arabic numeric style.
  /// </summary>
  wdListNumberStyleArabic = unchecked((int)0),
  /// <summary>
  /// Uppercase Roman style.
  /// </summary>
  wdListNumberStyleUppercaseRoman = unchecked((int)1),
  /// <summary>
  /// Lowercase Roman style.
  /// </summary>
  wdListNumberStyleLowercaseRoman = unchecked((int)2),
  /// <summary>
  /// Uppercase letter style.
  /// </summary>
  wdListNumberStyleUppercaseLetter = unchecked((int)3),
  /// <summary>
  /// Lowercase letter style.
  /// </summary>
  wdListNumberStyleLowercaseLetter = unchecked((int)4),
  /// <summary>
  /// Ordinal style.
  /// </summary>
  wdListNumberStyleOrdinal = unchecked((int)5),
  /// <summary>
  /// Cardinal text style.
  /// </summary>
  wdListNumberStyleCardinalText = unchecked((int)6),
  /// <summary>
  /// Ordinal text style.
  /// </summary>
  wdListNumberStyleOrdinalText = unchecked((int)7),
  /// <summary>
  /// Kanji style.
  /// </summary>
  wdListNumberStyleKanji = unchecked((int)10),
  /// <summary>
  /// Kanji Digit style.
  /// </summary>
  wdListNumberStyleKanjiDigit = unchecked((int)11),
  /// <summary>
  /// Aiueo half-width numeric style. [System.Runtime.InteropServices.Guid("9C1DBE08-4499-311E-B83E-27B844624F91")]
  /// public enum WdListNumberStyle ﾉ Expand table
  /// </summary>
  wdListNumberStyleAiueoHalfWidth = unchecked((int)12),
  /// <summary>
  /// Iroha half width style.
  /// </summary>
  wdListNumberStyleIrohaHalfWidth = unchecked((int)13),
  /// <summary>
  /// Arabic full-width numeric style.
  /// </summary>
  wdListNumberStyleArabicFullWidth = unchecked((int)14),
  /// <summary>
  /// Kanji traditional style.
  /// </summary>
  wdListNumberStyleKanjiTraditional = unchecked((int)16),
  /// <summary>
  /// Kanji
  /// </summary>
  wdListNumberStyleKanjiTraditional2 = unchecked((int)17),
  /// <summary>
  /// Number in circle style.
  /// </summary>
  wdListNumberStyleNumberInCircle = unchecked((int)18),
  /// <summary>
  /// Aiueo numeric style.
  /// </summary>
  wdListNumberStyleAiueo = unchecked((int)20),
  /// <summary>
  /// Iroha style.
  /// </summary>
  wdListNumberStyleIroha = unchecked((int)21),
  /// <summary>
  /// Arabic LZ numeric style.
  /// </summary>
  wdListNumberStyleArabicLZ = unchecked((int)22),
  /// <summary>
  /// Bullet style.
  /// </summary>
  wdListNumberStyleBullet = unchecked((int)23),
  /// <summary>
  /// Ganada style.
  /// </summary>
  wdListNumberStyleGanada = unchecked((int)24),
  /// <summary>
  /// Chosung style.
  /// </summary>
  wdListNumberStyleChosung = unchecked((int)25),
  /// <summary>
  /// GB
  /// </summary>
  wdListNumberStyleGBNum1 = unchecked((int)26),
  /// <summary>
  /// GB
  /// </summary>
  wdListNumberStyleGBNum2 = unchecked((int)27),
  /// <summary>
  /// GB
  /// </summary>
  wdListNumberStyleGBNum3 = unchecked((int)28),
  /// <summary>
  /// GB
  /// </summary>
  wdListNumberStyleGBNum4 = unchecked((int)29),
  /// <summary>
  /// Zodiac 1 style.
  /// </summary>
  wdListNumberStyleZodiac1 = unchecked((int)30),
  /// <summary>
  /// Zodiac 2 style.
  /// </summary>
  wdListNumberStyleZodiac2 = unchecked((int)31),
  /// <summary>
  /// Zodiac 3 style.
  /// </summary>
  wdListNumberStyleZodiac3 = unchecked((int)32),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  wdListNumberStyleTradChinNum1 = unchecked((int)33),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  wdListNumberStyleTradChinNum2 = unchecked((int)34),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  wdListNumberStyleTradChinNum3 = unchecked((int)35),
  /// <summary>
  /// Traditional Chinese
  /// </summary>
  wdListNumberStyleTradChinNum4 = unchecked((int)36),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  wdListNumberStyleSimpChinNum1 = unchecked((int)37),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  wdListNumberStyleSimpChinNum2 = unchecked((int)38),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  wdListNumberStyleSimpChinNum3 = unchecked((int)39),
  /// <summary>
  /// Simplified Chinese
  /// </summary>
  wdListNumberStyleSimpChinNum4 = unchecked((int)40),
  /// <summary>
  /// Hanja Read style.
  /// </summary>
  wdListNumberStyleHanjaRead = unchecked((int)41),
  /// <summary>
  /// Hanja Read Digit style.
  /// </summary>
  wdListNumberStyleHanjaReadDigit = unchecked((int)42),
  /// <summary>
  /// Hanqul style.
  /// </summary>
  wdListNumberStyleHangul = unchecked((int)43),
  /// <summary>
  /// Hanja style.
  /// </summary>
  wdListNumberStyleHanja = unchecked((int)44),
  /// <summary>
  /// Hebrew 1 style.
  /// </summary>
  wdListNumberStyleHebrew1 = unchecked((int)45),
  /// <summary>
  /// Arabic 1 numeric style.
  /// </summary>
  wdListNumberStyleArabic1 = unchecked((int)46),
  /// <summary>
  /// Hebrew 2 style.
  /// </summary>
  wdListNumberStyleHebrew2 = unchecked((int)47),
  /// <summary>
  /// Arabic 2 numeric style.
  /// </summary>
  wdListNumberStyleArabic2 = unchecked((int)48),
  /// <summary>
  /// Hindi
  /// </summary>
  wdListNumberStyleHindiLetter1 = unchecked((int)49),
  /// <summary>
  /// Hindi
  /// </summary>
  wdListNumberStyleHindiLetter2 = unchecked((int)50),
  /// <summary>
  /// Hindi Arabic style.
  /// </summary>
  wdListNumberStyleHindiArabic = unchecked((int)51),
  /// <summary>
  /// Hindi Cardinal text style.
  /// </summary>
  wdListNumberStyleHindiCardinalText = unchecked((int)52),
  /// <summary>
  /// Thai letter style.
  /// </summary>
  wdListNumberStyleThaiLetter = unchecked((int)53),
  /// <summary>
  /// Thai Arabic style.
  /// </summary>
  wdListNumberStyleThaiArabic = unchecked((int)54),
  /// <summary>
  /// Thai Cardinal text style.
  /// </summary>
  wdListNumberStyleThaiCardinalText = unchecked((int)55),
  /// <summary>
  /// Vietnamese Cardinal text style.
  /// </summary>
  wdListNumberStyleVietCardinalText = unchecked((int)56),
  /// <summary>
  /// Lowercase Russian style.
  /// </summary>
  wdListNumberStyleLowercaseRussian = unchecked((int)58),
  /// <summary>
  /// Uppercase Russian style.
  /// </summary>
  wdListNumberStyleUppercaseRussian = unchecked((int)59),
  /// <summary>
  /// wdListNumberStyleUppercaseGreek 61
  /// </summary>
  wdListNumberStyleLowercaseGreek = unchecked((int)60),
  /// <summary>
  /// wdListNumberStyleArabicLZ2 62
  /// </summary>
  wdListNumberStyleUppercaseGreek = unchecked((int)61),
  /// <summary>
  /// wdListNumberStyleArabicLZ3 63
  /// </summary>
  wdListNumberStyleArabicLZ2 = unchecked((int)62),
  /// <summary>
  /// wdListNumberStyleArabicLZ4 64
  /// </summary>
  wdListNumberStyleArabicLZ3 = unchecked((int)63),
  /// <summary>
  /// wdListNumberStyleLowercaseTurkish 65
  /// </summary>
  wdListNumberStyleArabicLZ4 = unchecked((int)64),
  /// <summary>
  /// wdListNumberStyleUppercaseTurkish 66
  /// </summary>
  wdListNumberStyleLowercaseTurkish = unchecked((int)65),
  /// <summary>
  /// wdListNumberStyleLowercaseBulgarian 67
  /// </summary>
  wdListNumberStyleUppercaseTurkish = unchecked((int)66),
  /// <summary>
  /// wdListNumberStyleUppercaseBulgarian 68
  /// </summary>
  wdListNumberStyleLowercaseBulgarian = unchecked((int)67),
  /// <summary>
  /// wdListNumberStylePictureBullet 249 Picture bullet style.
  /// </summary>
  wdListNumberStyleUppercaseBulgarian = unchecked((int)68),
  /// <summary>
  /// Picture bullet style.
  /// </summary>
  wdListNumberStylePictureBullet = unchecked((int)249),
  /// <summary>
  /// Legal style.
  /// </summary>
  wdListNumberStyleLegal = unchecked((int)253),
  /// <summary>
  /// Legal LZ style.
  /// </summary>
  wdListNumberStyleLegalLZ = unchecked((int)254),
  /// <summary>
  /// No style applied.
  /// </summary>
  wdListNumberStyleNone = unchecked((int)255)
}
