namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the NumberFormatValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.NumberFormatValues))]
public enum NumberFormat
{
  /// <summary>
  ///   Decimal Numbers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Decimal))]
  Decimal,
  /// <summary>
  ///   Uppercase Roman Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.UpperRoman))]
  UpperRoman,
  /// <summary>
  ///   Lowercase Roman Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.LowerRoman))]
  LowerRoman,
  /// <summary>
  ///   Uppercase Latin Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.UpperLetter))]
  UpperLetter,
  /// <summary>
  ///   Lowercase Latin Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.LowerLetter))]
  LowerLetter,
  /// <summary>
  ///   Ordinal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Ordinal))]
  Ordinal,
  /// <summary>
  ///   Cardinal Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.CardinalText))]
  CardinalText,
  /// <summary>
  ///   Ordinal Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.OrdinalText))]
  OrdinalText,
  /// <summary>
  ///   Hexadecimal Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Hex))]
  Hex,
  /// <summary>
  ///   Chicago Manual of IStyle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Chicago))]
  Chicago,
  /// <summary>
  ///   Ideographs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IdeographDigital))]
  IdeographDigital,
  /// <summary>
  ///   Japanese Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.JapaneseCounting))]
  JapaneseCounting,
  /// <summary>
  ///   AIUEO Order Hiragana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Aiueo))]
  Aiueo,
  /// <summary>
  ///   Iroha Ordered Katakana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Iroha))]
  Iroha,
  /// <summary>
  ///   Double Byte Arabic Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalFullWidth))]
  DecimalFullWidth,
  /// <summary>
  ///   Single Byte Arabic Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalHalfWidth))]
  DecimalHalfWidth,
  /// <summary>
  ///   Japanese Legal Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.JapaneseLegal))]
  JapaneseLegal,
  /// <summary>
  ///   Japanese Digital Ten Thousand Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.JapaneseDigitalTenThousand))]
  JapaneseDigitalTenThousand,
  /// <summary>
  ///   Decimal Numbers Enclosed in a Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalEnclosedCircle))]
  DecimalEnclosedCircle,
  /// <summary>
  ///   Double Byte Arabic Numerals Alternate.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalFullWidth2))]
  DecimalFullWidth2,
  /// <summary>
  ///   Full-Width AIUEO Order Hiragana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.AiueoFullWidth))]
  AiueoFullWidth,
  /// <summary>
  ///   Full-Width Iroha Ordered Katakana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IrohaFullWidth))]
  IrohaFullWidth,
  /// <summary>
  ///   Initial Zero Arabic Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalZero))]
  DecimalZero,
  /// <summary>
  ///   Bullet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Bullet))]
  Bullet,
  /// <summary>
  ///   Korean Ganada Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Ganada))]
  Ganada,
  /// <summary>
  ///   Korean Chosung Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Chosung))]
  Chosung,
  /// <summary>
  ///   Decimal Numbers Followed by a Period.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalEnclosedFullstop))]
  DecimalEnclosedFullstop,
  /// <summary>
  ///   Decimal Numbers Enclosed in Parenthesis.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalEnclosedParen))]
  DecimalEnclosedParen,
  /// <summary>
  ///   Decimal Numbers Enclosed in a Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DecimalEnclosedCircleChinese))]
  DecimalEnclosedCircleChinese,
  /// <summary>
  ///   Ideographs Enclosed in a Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IdeographEnclosedCircle))]
  IdeographEnclosedCircle,
  /// <summary>
  ///   Traditional Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IdeographTraditional))]
  IdeographTraditional,
  /// <summary>
  ///   Zodiac Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IdeographZodiac))]
  IdeographZodiac,
  /// <summary>
  ///   Traditional Zodiac Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IdeographZodiacTraditional))]
  IdeographZodiacTraditional,
  /// <summary>
  ///   Taiwanese Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.TaiwaneseCounting))]
  TaiwaneseCounting,
  /// <summary>
  ///   Traditional Legal Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.IdeographLegalTraditional))]
  IdeographLegalTraditional,
  /// <summary>
  ///   Taiwanese Counting Thousand System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.TaiwaneseCountingThousand))]
  TaiwaneseCountingThousand,
  /// <summary>
  ///   Taiwanese Digital Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.TaiwaneseDigital))]
  TaiwaneseDigital,
  /// <summary>
  ///   Chinese Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ChineseCounting))]
  ChineseCounting,
  /// <summary>
  ///   Chinese Legal Simplified Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ChineseLegalSimplified))]
  ChineseLegalSimplified,
  /// <summary>
  ///   Chinese Counting Thousand System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ChineseCountingThousand))]
  ChineseCountingThousand,
  /// <summary>
  ///   Korean Digital Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.KoreanDigital))]
  KoreanDigital,
  /// <summary>
  ///   Korean Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.KoreanCounting))]
  KoreanCounting,
  /// <summary>
  ///   Korean Legal Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.KoreanLegal))]
  KoreanLegal,
  /// <summary>
  ///   Korean Digital Counting System Alternate.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.KoreanDigital2))]
  KoreanDigital2,
  /// <summary>
  ///   Vietnamese Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.VietnameseCounting))]
  VietnameseCounting,
  /// <summary>
  ///   Lowercase Russian Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.RussianLower))]
  RussianLower,
  /// <summary>
  ///   Uppercase Russian Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.RussianUpper))]
  RussianUpper,
  /// <summary>
  ///   No Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.None))]
  None,
  /// <summary>
  ///   Number With Dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.NumberInDash))]
  NumberInDash,
  /// <summary>
  ///   Hebrew Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Hebrew1))]
  Hebrew1,
  /// <summary>
  ///   Hebrew Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Hebrew2))]
  Hebrew2,
  /// <summary>
  ///   Arabic Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ArabicAlpha))]
  ArabicAlpha,
  /// <summary>
  ///   Arabic Abjad Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ArabicAbjad))]
  ArabicAbjad,
  /// <summary>
  ///   Hindi Vowels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.HindiVowels))]
  HindiVowels,
  /// <summary>
  ///   Hindi Consonants.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.HindiConsonants))]
  HindiConsonants,
  /// <summary>
  ///   Hindi Numbers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.HindiNumbers))]
  HindiNumbers,
  /// <summary>
  ///   Hindi Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.HindiCounting))]
  HindiCounting,
  /// <summary>
  ///   Thai Letters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ThaiLetters))]
  ThaiLetters,
  /// <summary>
  ///   Thai Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ThaiNumbers))]
  ThaiNumbers,
  /// <summary>
  ///   Thai Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.ThaiCounting))]
  ThaiCounting,
  /// <summary>
  ///   bahtText.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.BahtText))]
  BahtText,
  /// <summary>
  ///   dollarText.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.DollarText))]
  DollarText,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.NumberFormatValues.Custom))]
  Custom
}
