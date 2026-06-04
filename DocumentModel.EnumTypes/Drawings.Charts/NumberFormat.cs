namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the NumberFormatValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues))]
public enum NumberFormat
{
  /// <summary>
  ///   Decimal Numbers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Decimal))]
  Decimal,
  /// <summary>
  ///   Uppercase Roman Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.UpperRoman))]
  UpperRoman,
  /// <summary>
  ///   Lowercase Roman Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.LowerRoman))]
  LowerRoman,
  /// <summary>
  ///   Uppercase Latin Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.UpperLetter))]
  UpperLetter,
  /// <summary>
  ///   Lowercase Latin Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.LowerLetter))]
  LowerLetter,
  /// <summary>
  ///   Ordinal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Ordinal))]
  Ordinal,
  /// <summary>
  ///   Cardinal Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.CardinalText))]
  CardinalText,
  /// <summary>
  ///   Ordinal Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.OrdinalText))]
  OrdinalText,
  /// <summary>
  ///   Hexadecimal Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Hex))]
  Hex,
  /// <summary>
  ///   Chicago Manual of IStyle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Chicago))]
  Chicago,
  /// <summary>
  ///   Ideographs.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IdeographDigital))]
  IdeographDigital,
  /// <summary>
  ///   Japanese Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.JapaneseCounting))]
  JapaneseCounting,
  /// <summary>
  ///   AIUEO Order Hiragana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Aiueo))]
  Aiueo,
  /// <summary>
  ///   Iroha Ordered Katakana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Iroha))]
  Iroha,
  /// <summary>
  ///   Double Byte Arabic Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalFullWidth))]
  DecimalFullWidth,
  /// <summary>
  ///   Single Byte Arabic Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalHalfWidth))]
  DecimalHalfWidth,
  /// <summary>
  ///   Japanese Legal Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.JapaneseLegal))]
  JapaneseLegal,
  /// <summary>
  ///   Japanese Digital Ten Thousand Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.JapaneseDigitalTenThousand))]
  JapaneseDigitalTenThousand,
  /// <summary>
  ///   Decimal Numbers Enclosed in a Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalEnclosedCircle))]
  DecimalEnclosedCircle,
  /// <summary>
  ///   Double Byte Arabic Numerals Alternate.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalFullWidth2))]
  DecimalFullWidth2,
  /// <summary>
  ///   Full-Width AIUEO Order Hiragana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.AiueoFullWidth))]
  AiueoFullWidth,
  /// <summary>
  ///   Full-Width Iroha Ordered Katakana.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IrohaFullWidth))]
  IrohaFullWidth,
  /// <summary>
  ///   Initial Zero Arabic Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalZero))]
  DecimalZero,
  /// <summary>
  ///   Bullet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Bullet))]
  Bullet,
  /// <summary>
  ///   Korean Ganada Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Ganada))]
  Ganada,
  /// <summary>
  ///   Korean Chosung Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Chosung))]
  Chosung,
  /// <summary>
  ///   Decimal Numbers Followed by a Period.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalEnclosedFullstop))]
  DecimalEnclosedFullstop,
  /// <summary>
  ///   Decimal Numbers Enclosed in Parenthesis.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalEnclosedParen))]
  DecimalEnclosedParen,
  /// <summary>
  ///   Decimal Numbers Enclosed in a Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DecimalEnclosedCircleChinese))]
  DecimalEnclosedCircleChinese,
  /// <summary>
  ///   Ideographs Enclosed in a Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IdeographEnclosedCircle))]
  IdeographEnclosedCircle,
  /// <summary>
  ///   Traditional Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IdeographTraditional))]
  IdeographTraditional,
  /// <summary>
  ///   Zodiac Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IdeographZodiac))]
  IdeographZodiac,
  /// <summary>
  ///   Traditional Zodiac Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IdeographZodiacTraditional))]
  IdeographZodiacTraditional,
  /// <summary>
  ///   Taiwanese Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.TaiwaneseCounting))]
  TaiwaneseCounting,
  /// <summary>
  ///   Traditional Legal Ideograph Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.IdeographLegalTraditional))]
  IdeographLegalTraditional,
  /// <summary>
  ///   Taiwanese Counting Thousand System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.TaiwaneseCountingThousand))]
  TaiwaneseCountingThousand,
  /// <summary>
  ///   Taiwanese Digital Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.TaiwaneseDigital))]
  TaiwaneseDigital,
  /// <summary>
  ///   Chinese Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ChineseCounting))]
  ChineseCounting,
  /// <summary>
  ///   Chinese Legal Simplified Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ChineseLegalSimplified))]
  ChineseLegalSimplified,
  /// <summary>
  ///   Chinese Counting Thousand System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ChineseCountingThousand))]
  ChineseCountingThousand,
  /// <summary>
  ///   Korean Digital Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.KoreanDigital))]
  KoreanDigital,
  /// <summary>
  ///   Korean Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.KoreanCounting))]
  KoreanCounting,
  /// <summary>
  ///   Korean Legal Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.KoreanLegal))]
  KoreanLegal,
  /// <summary>
  ///   Korean Digital Counting System Alternate.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.KoreanDigital2))]
  KoreanDigital2,
  /// <summary>
  ///   Vietnamese Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.VietnameseCounting))]
  VietnameseCounting,
  /// <summary>
  ///   Lowercase Russian Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.RussianLower))]
  RussianLower,
  /// <summary>
  ///   Uppercase Russian Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.RussianUpper))]
  RussianUpper,
  /// <summary>
  ///   No Numbering.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.None))]
  None,
  /// <summary>
  ///   Number With Dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.NumberInDash))]
  NumberInDash,
  /// <summary>
  ///   Hebrew Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Hebrew1))]
  Hebrew1,
  /// <summary>
  ///   Hebrew Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Hebrew2))]
  Hebrew2,
  /// <summary>
  ///   Arabic Alphabet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ArabicAlpha))]
  ArabicAlpha,
  /// <summary>
  ///   Arabic Abjad Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ArabicAbjad))]
  ArabicAbjad,
  /// <summary>
  ///   Hindi Vowels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.HindiVowels))]
  HindiVowels,
  /// <summary>
  ///   Hindi Consonants.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.HindiConsonants))]
  HindiConsonants,
  /// <summary>
  ///   Hindi Numbers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.HindiNumbers))]
  HindiNumbers,
  /// <summary>
  ///   Hindi Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.HindiCounting))]
  HindiCounting,
  /// <summary>
  ///   Thai Letters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ThaiLetters))]
  ThaiLetters,
  /// <summary>
  ///   Thai Numerals.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ThaiNumbers))]
  ThaiNumbers,
  /// <summary>
  ///   Thai Counting System.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.ThaiCounting))]
  ThaiCounting,
  /// <summary>
  ///   bahtText.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.BahtText))]
  BahtText,
  /// <summary>
  ///   dollarText.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.DollarText))]
  DollarText,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues.Custom))]
  Custom
}
