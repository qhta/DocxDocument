namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberFormatValues enumeration.
/// </summary>
public enum NumberFormatValues
{
  /// <summary>
  /// Decimal Numbers.
  /// </summary>
  [XmlEnum("decimal")]
  Decimal,
  
  /// <summary>
  /// Uppercase Roman Numerals.
  /// </summary>
  [XmlEnum("upperRoman")]
  UpperRoman,
  
  /// <summary>
  /// Lowercase Roman Numerals.
  /// </summary>
  [XmlEnum("lowerRoman")]
  LowerRoman,
  
  /// <summary>
  /// Uppercase Latin Alphabet.
  /// </summary>
  [XmlEnum("upperLetter")]
  UpperLetter,
  
  /// <summary>
  /// Lowercase Latin Alphabet.
  /// </summary>
  [XmlEnum("lowerLetter")]
  LowerLetter,
  
  /// <summary>
  /// Ordinal.
  /// </summary>
  [XmlEnum("ordinal")]
  Ordinal,
  
  /// <summary>
  /// Cardinal Text.
  /// </summary>
  [XmlEnum("cardinalText")]
  CardinalText,
  
  /// <summary>
  /// Ordinal Text.
  /// </summary>
  [XmlEnum("ordinalText")]
  OrdinalText,
  
  /// <summary>
  /// Hexadecimal Numbering.
  /// </summary>
  [XmlEnum("hex")]
  Hex,
  
  /// <summary>
  /// Chicago Manual of Style.
  /// </summary>
  [XmlEnum("chicago")]
  Chicago,
  
  /// <summary>
  /// Ideographs.
  /// </summary>
  [XmlEnum("ideographDigital")]
  IdeographDigital,
  
  /// <summary>
  /// Japanese Counting System.
  /// </summary>
  [XmlEnum("japaneseCounting")]
  JapaneseCounting,
  
  /// <summary>
  /// AIUEO Order Hiragana.
  /// </summary>
  [XmlEnum("aiueo")]
  Aiueo,
  
  /// <summary>
  /// Iroha Ordered Katakana.
  /// </summary>
  [XmlEnum("iroha")]
  Iroha,
  
  /// <summary>
  /// Double Byte Arabic Numerals.
  /// </summary>
  [XmlEnum("decimalFullWidth")]
  DecimalFullWidth,
  
  /// <summary>
  /// Single Byte Arabic Numerals.
  /// </summary>
  [XmlEnum("decimalHalfWidth")]
  DecimalHalfWidth,
  
  /// <summary>
  /// Japanese Legal Numbering.
  /// </summary>
  [XmlEnum("japaneseLegal")]
  JapaneseLegal,
  
  /// <summary>
  /// Japanese Digital Ten Thousand Counting System.
  /// </summary>
  [XmlEnum("japaneseDigitalTenThousand")]
  JapaneseDigitalTenThousand,
  
  /// <summary>
  /// Decimal Numbers Enclosed in a Circle.
  /// </summary>
  [XmlEnum("decimalEnclosedCircle")]
  DecimalEnclosedCircle,
  
  /// <summary>
  /// Double Byte Arabic Numerals Alternate.
  /// </summary>
  [XmlEnum("decimalFullWidth2")]
  DecimalFullWidth2,
  
  /// <summary>
  /// Full-Width AIUEO Order Hiragana.
  /// </summary>
  [XmlEnum("aiueoFullWidth")]
  AiueoFullWidth,
  
  /// <summary>
  /// Full-Width Iroha Ordered Katakana.
  /// </summary>
  [XmlEnum("irohaFullWidth")]
  IrohaFullWidth,
  
  /// <summary>
  /// Initial Zero Arabic Numerals.
  /// </summary>
  [XmlEnum("decimalZero")]
  DecimalZero,
  
  /// <summary>
  /// Bullet.
  /// </summary>
  [XmlEnum("bullet")]
  Bullet,
  
  /// <summary>
  /// Korean Ganada Numbering.
  /// </summary>
  [XmlEnum("ganada")]
  Ganada,
  
  /// <summary>
  /// Korean Chosung Numbering.
  /// </summary>
  [XmlEnum("chosung")]
  Chosung,
  
  /// <summary>
  /// Decimal Numbers Followed by a Period.
  /// </summary>
  [XmlEnum("decimalEnclosedFullstop")]
  DecimalEnclosedFullstop,
  
  /// <summary>
  /// Decimal Numbers Enclosed in Parenthesis.
  /// </summary>
  [XmlEnum("decimalEnclosedParen")]
  DecimalEnclosedParen,
  
  /// <summary>
  /// Decimal Numbers Enclosed in a Circle.
  /// </summary>
  [XmlEnum("decimalEnclosedCircleChinese")]
  DecimalEnclosedCircleChinese,
  
  /// <summary>
  /// Ideographs Enclosed in a Circle.
  /// </summary>
  [XmlEnum("ideographEnclosedCircle")]
  IdeographEnclosedCircle,
  
  /// <summary>
  /// Traditional Ideograph Format.
  /// </summary>
  [XmlEnum("ideographTraditional")]
  IdeographTraditional,
  
  /// <summary>
  /// Zodiac Ideograph Format.
  /// </summary>
  [XmlEnum("ideographZodiac")]
  IdeographZodiac,
  
  /// <summary>
  /// Traditional Zodiac Ideograph Format.
  /// </summary>
  [XmlEnum("ideographZodiacTraditional")]
  IdeographZodiacTraditional,
  
  /// <summary>
  /// Taiwanese Counting System.
  /// </summary>
  [XmlEnum("taiwaneseCounting")]
  TaiwaneseCounting,
  
  /// <summary>
  /// Traditional Legal Ideograph Format.
  /// </summary>
  [XmlEnum("ideographLegalTraditional")]
  IdeographLegalTraditional,
  
  /// <summary>
  /// Taiwanese Counting Thousand System.
  /// </summary>
  [XmlEnum("taiwaneseCountingThousand")]
  TaiwaneseCountingThousand,
  
  /// <summary>
  /// Taiwanese Digital Counting System.
  /// </summary>
  [XmlEnum("taiwaneseDigital")]
  TaiwaneseDigital,
  
  /// <summary>
  /// Chinese Counting System.
  /// </summary>
  [XmlEnum("chineseCounting")]
  ChineseCounting,
  
  /// <summary>
  /// Chinese Legal Simplified Format.
  /// </summary>
  [XmlEnum("chineseLegalSimplified")]
  ChineseLegalSimplified,
  
  /// <summary>
  /// Chinese Counting Thousand System.
  /// </summary>
  [XmlEnum("chineseCountingThousand")]
  ChineseCountingThousand,
  
  /// <summary>
  /// Korean Digital Counting System.
  /// </summary>
  [XmlEnum("koreanDigital")]
  KoreanDigital,
  
  /// <summary>
  /// Korean Counting System.
  /// </summary>
  [XmlEnum("koreanCounting")]
  KoreanCounting,
  
  /// <summary>
  /// Korean Legal Numbering.
  /// </summary>
  [XmlEnum("koreanLegal")]
  KoreanLegal,
  
  /// <summary>
  /// Korean Digital Counting System Alternate.
  /// </summary>
  [XmlEnum("koreanDigital2")]
  KoreanDigital2,
  
  /// <summary>
  /// Vietnamese Numerals.
  /// </summary>
  [XmlEnum("vietnameseCounting")]
  VietnameseCounting,
  
  /// <summary>
  /// Lowercase Russian Alphabet.
  /// </summary>
  [XmlEnum("russianLower")]
  RussianLower,
  
  /// <summary>
  /// Uppercase Russian Alphabet.
  /// </summary>
  [XmlEnum("russianUpper")]
  RussianUpper,
  
  /// <summary>
  /// No Numbering.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Number With Dashes.
  /// </summary>
  [XmlEnum("numberInDash")]
  NumberInDash,
  
  /// <summary>
  /// Hebrew Numerals.
  /// </summary>
  [XmlEnum("hebrew1")]
  Hebrew1,
  
  /// <summary>
  /// Hebrew Alphabet.
  /// </summary>
  [XmlEnum("hebrew2")]
  Hebrew2,
  
  /// <summary>
  /// Arabic Alphabet.
  /// </summary>
  [XmlEnum("arabicAlpha")]
  ArabicAlpha,
  
  /// <summary>
  /// Arabic Abjad Numerals.
  /// </summary>
  [XmlEnum("arabicAbjad")]
  ArabicAbjad,
  
  /// <summary>
  /// Hindi Vowels.
  /// </summary>
  [XmlEnum("hindiVowels")]
  HindiVowels,
  
  /// <summary>
  /// Hindi Consonants.
  /// </summary>
  [XmlEnum("hindiConsonants")]
  HindiConsonants,
  
  /// <summary>
  /// Hindi Numbers.
  /// </summary>
  [XmlEnum("hindiNumbers")]
  HindiNumbers,
  
  /// <summary>
  /// Hindi Counting System.
  /// </summary>
  [XmlEnum("hindiCounting")]
  HindiCounting,
  
  /// <summary>
  /// Thai Letters.
  /// </summary>
  [XmlEnum("thaiLetters")]
  ThaiLetters,
  
  /// <summary>
  /// Thai Numerals.
  /// </summary>
  [XmlEnum("thaiNumbers")]
  ThaiNumbers,
  
  /// <summary>
  /// Thai Counting System.
  /// </summary>
  [XmlEnum("thaiCounting")]
  ThaiCounting,
  
  /// <summary>
  /// bahtText.
  /// </summary>
  [XmlEnum("bahtText")]
  BahtText,
  
  /// <summary>
  /// dollarText.
  /// </summary>
  [XmlEnum("dollarText")]
  DollarText,
  
  /// <summary>
  /// custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
