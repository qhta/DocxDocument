namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum NumberingFormat
{
  /// <summary>
  /// Decimal numbers
  /// </summary>
  Decimal,
  /// <summary>
  /// Uppercase Roman numerals. Numbering starts from "I"
  /// </summary>
  UpperRoman,
  /// <summary>
  /// Lowercase Roman numerals. Numbering starts from "i"
  /// </summary>
  LowerRoman,
  /// <summary>
  /// Uppercase Latin Alphabet. Numbering starts from "A"
  /// </summary>
  UpperLetter,
  /// <summary>
  /// Lowercase Latin Alphabet. Numbering starts from "a"
  /// </summary>
  LowerLetter,
  //
  // Summary:
  //     Ordinal.
  //     When the item is serialized out as xml, its value is "ordinal".
  //[EnumString("ordinal")]
  Ordinal,
  //
  // Summary:
  //     Cardinal Text.
  //     When the item is serialized out as xml, its value is "cardinalText".
  //[EnumString("cardinalText")]
  CardinalText,
  //
  // Summary:
  //     Ordinal Text.
  //     When the item is serialized out as xml, its value is "ordinalText".
  //[EnumString("ordinalText")]
  OrdinalText,
  //
  // Summary:
  //     Hexadecimal Numbering.
  //     When the item is serialized out as xml, its value is "hex".
  //[EnumString("hex")]
  Hex,
  //
  // Summary:
  //     Chicago Manual of Style.
  //     When the item is serialized out as xml, its value is "chicago".
  //[EnumString("chicago")]
  Chicago,
  //
  // Summary:
  //     Ideographs.
  //     When the item is serialized out as xml, its value is "ideographDigital".
  //[EnumString("ideographDigital")]
  IdeographDigital,
  //
  // Summary:
  //     Japanese Counting System.
  //     When the item is serialized out as xml, its value is "japaneseCounting".
  //[EnumString("japaneseCounting")]
  JapaneseCounting,
  //
  // Summary:
  //     AIUEO Order Hiragana.
  //     When the item is serialized out as xml, its value is "aiueo".
  //[EnumString("aiueo")]
  Aiueo,
  //
  // Summary:
  //     Iroha Ordered Katakana.
  //     When the item is serialized out as xml, its value is "iroha".
  //[EnumString("iroha")]
  Iroha,
  //
  // Summary:
  //     Double Byte Arabic Numerals.
  //     When the item is serialized out as xml, its value is "decimalFullWidth".
  //[EnumString("decimalFullWidth")]
  DecimalFullWidth,
  //
  // Summary:
  //     Single Byte Arabic Numerals.
  //     When the item is serialized out as xml, its value is "decimalHalfWidth".
  //[EnumString("decimalHalfWidth")]
  DecimalHalfWidth,
  //
  // Summary:
  //     Japanese Legal Numbering.
  //     When the item is serialized out as xml, its value is "japaneseLegal".
  //[EnumString("japaneseLegal")]
  JapaneseLegal,
  //
  // Summary:
  //     Japanese Digital Ten Thousand Counting System.
  //     When the item is serialized out as xml, its value is "japaneseDigitalTenThousand".
  //[EnumString("japaneseDigitalTenThousand")]
  JapaneseDigitalTenThousand,
  //
  // Summary:
  //     Decimal Numbers Enclosed in a Circle.
  //     When the item is serialized out as xml, its value is "decimalEnclosedCircle".
  //[EnumString("decimalEnclosedCircle")]
  DecimalEnclosedCircle,
  //
  // Summary:
  //     Double Byte Arabic Numerals Alternate.
  //     When the item is serialized out as xml, its value is "decimalFullWidth2".
  //[EnumString("decimalFullWidth2")]
  DecimalFullWidth2,
  //
  // Summary:
  //     Full-Width AIUEO Order Hiragana.
  //     When the item is serialized out as xml, its value is "aiueoFullWidth".
  //[EnumString("aiueoFullWidth")]
  AiueoFullWidth,
  //
  // Summary:
  //     Full-Width Iroha Ordered Katakana.
  //     When the item is serialized out as xml, its value is "irohaFullWidth".
  //[EnumString("irohaFullWidth")]
  IrohaFullWidth,
  //
  // Summary:
  //     Initial Zero Arabic Numerals.
  //     When the item is serialized out as xml, its value is "decimalZero".
  //[EnumString("decimalZero")]
  DecimalZero,
  //
  // Summary:
  //     Bullet.
  //     When the item is serialized out as xml, its value is "bullet".
  //[EnumString("bullet")]
  Bullet,
  //
  // Summary:
  //     Korean Ganada Numbering.
  //     When the item is serialized out as xml, its value is "ganada".
  //[EnumString("ganada")]
  Ganada,
  //
  // Summary:
  //     Korean Chosung Numbering.
  //     When the item is serialized out as xml, its value is "chosung".
  //[EnumString("chosung")]
  Chosung,
  //
  // Summary:
  //     Decimal Numbers Followed by a Period.
  //     When the item is serialized out as xml, its value is "decimalEnclosedFullstop".
  //[EnumString("decimalEnclosedFullstop")]
  DecimalEnclosedFullstop,
  //
  // Summary:
  //     Decimal Numbers Enclosed in Parenthesis.
  //     When the item is serialized out as xml, its value is "decimalEnclosedParen".
  //[EnumString("decimalEnclosedParen")]
  DecimalEnclosedParen,
  //
  // Summary:
  //     Decimal Numbers Enclosed in a Circle.
  //     When the item is serialized out as xml, its value is "decimalEnclosedCircleChinese".
  //[EnumString("decimalEnclosedCircleChinese")]
  DecimalEnclosedCircleChinese,
  //
  // Summary:
  //     Ideographs Enclosed in a Circle.
  //     When the item is serialized out as xml, its value is "ideographEnclosedCircle".
  //[EnumString("ideographEnclosedCircle")]
  IdeographEnclosedCircle,
  //
  // Summary:
  //     Traditional Ideograph Format.
  //     When the item is serialized out as xml, its value is "ideographTraditional".
  //[EnumString("ideographTraditional")]
  IdeographTraditional,
  //
  // Summary:
  //     Zodiac Ideograph Format.
  //     When the item is serialized out as xml, its value is "ideographZodiac".
  //[EnumString("ideographZodiac")]
  IdeographZodiac,
  //
  // Summary:
  //     Traditional Zodiac Ideograph Format.
  //     When the item is serialized out as xml, its value is "ideographZodiacTraditional".
  //[EnumString("ideographZodiacTraditional")]
  IdeographZodiacTraditional,
  //
  // Summary:
  //     Taiwanese Counting System.
  //     When the item is serialized out as xml, its value is "taiwaneseCounting".
  //[EnumString("taiwaneseCounting")]
  TaiwaneseCounting,
  //
  // Summary:
  //     Traditional Legal Ideograph Format.
  //     When the item is serialized out as xml, its value is "ideographLegalTraditional".
  //[EnumString("ideographLegalTraditional")]
  IdeographLegalTraditional,
  //
  // Summary:
  //     Taiwanese Counting Thousand System.
  //     When the item is serialized out as xml, its value is "taiwaneseCountingThousand".
  //[EnumString("taiwaneseCountingThousand")]
  TaiwaneseCountingThousand,
  //
  // Summary:
  //     Taiwanese Digital Counting System.
  //     When the item is serialized out as xml, its value is "taiwaneseDigital".
  //[EnumString("taiwaneseDigital")]
  TaiwaneseDigital,
  //
  // Summary:
  //     Chinese Counting System.
  //     When the item is serialized out as xml, its value is "chineseCounting".
  //[EnumString("chineseCounting")]
  ChineseCounting,
  //
  // Summary:
  //     Chinese Legal Simplified Format.
  //     When the item is serialized out as xml, its value is "chineseLegalSimplified".
  //[EnumString("chineseLegalSimplified")]
  ChineseLegalSimplified,
  //
  // Summary:
  //     Chinese Counting Thousand System.
  //     When the item is serialized out as xml, its value is "chineseCountingThousand".
  //[EnumString("chineseCountingThousand")]
  ChineseCountingThousand,
  //
  // Summary:
  //     Korean Digital Counting System.
  //     When the item is serialized out as xml, its value is "koreanDigital".
  //[EnumString("koreanDigital")]
  KoreanDigital,
  //
  // Summary:
  //     Korean Counting System.
  //     When the item is serialized out as xml, its value is "koreanCounting".
  //[EnumString("koreanCounting")]
  KoreanCounting,
  //
  // Summary:
  //     Korean Legal Numbering.
  //     When the item is serialized out as xml, its value is "koreanLegal".
  //[EnumString("koreanLegal")]
  KoreanLegal,
  //
  // Summary:
  //     Korean Digital Counting System Alternate.
  //     When the item is serialized out as xml, its value is "koreanDigital2".
  //[EnumString("koreanDigital2")]
  KoreanDigital2,
  //
  // Summary:
  //     Vietnamese Numerals.
  //     When the item is serialized out as xml, its value is "vietnameseCounting".
  //[EnumString("vietnameseCounting")]
  VietnameseCounting,
  //
  // Summary:
  //     Lowercase Russian Alphabet.
  //     When the item is serialized out as xml, its value is "russianLower".
  //[EnumString("russianLower")]
  RussianLower,
  //
  // Summary:
  //     Uppercase Russian Alphabet.
  //     When the item is serialized out as xml, its value is "russianUpper".
  //[EnumString("russianUpper")]
  RussianUpper,
  //
  // Summary:
  //     No Numbering.
  //     When the item is serialized out as xml, its value is "none".
  //[EnumString("none")]
  None,
  //
  // Summary:
  //     Number With Dashes.
  //     When the item is serialized out as xml, its value is "numberInDash".
  //[EnumString("numberInDash")]
  NumberInDash,
  //
  // Summary:
  //     Hebrew Numerals.
  //     When the item is serialized out as xml, its value is "hebrew1".
  //[EnumString("hebrew1")]
  Hebrew1,
  //
  // Summary:
  //     Hebrew Alphabet.
  //     When the item is serialized out as xml, its value is "hebrew2".
  //[EnumString("hebrew2")]
  Hebrew2,
  //
  // Summary:
  //     Arabic Alphabet.
  //     When the item is serialized out as xml, its value is "arabicAlpha".
  //[EnumString("arabicAlpha")]
  ArabicAlpha,
  //
  // Summary:
  //     Arabic Abjad Numerals.
  //     When the item is serialized out as xml, its value is "arabicAbjad".
  //[EnumString("arabicAbjad")]
  ArabicAbjad,
  //
  // Summary:
  //     Hindi Vowels.
  //     When the item is serialized out as xml, its value is "hindiVowels".
  //[EnumString("hindiVowels")]
  HindiVowels,
  //
  // Summary:
  //     Hindi Consonants.
  //     When the item is serialized out as xml, its value is "hindiConsonants".
  //[EnumString("hindiConsonants")]
  HindiConsonants,
  //
  // Summary:
  //     Hindi Numbers.
  //     When the item is serialized out as xml, its value is "hindiNumbers".
  //[EnumString("hindiNumbers")]
  HindiNumbers,
  //
  // Summary:
  //     Hindi Counting System.
  //     When the item is serialized out as xml, its value is "hindiCounting".
  //[EnumString("hindiCounting")]
  HindiCounting,
  //
  // Summary:
  //     Thai Letters.
  //     When the item is serialized out as xml, its value is "thaiLetters".
  //[EnumString("thaiLetters")]
  ThaiLetters,
  //
  // Summary:
  //     Thai Numerals.
  //     When the item is serialized out as xml, its value is "thaiNumbers".
  //[EnumString("thaiNumbers")]
  ThaiNumbers,
  //
  // Summary:
  //     Thai Counting System.
  //     When the item is serialized out as xml, its value is "thaiCounting".
  //[EnumString("thaiCounting")]
  ThaiCounting,
  //
  // Summary:
  //     bahtText.
  //     When the item is serialized out as xml, its value is "bahtText".
  //[EnumString("bahtText")]
  BahtText,
  //
  // Summary:
  //     dollarText.
  //     When the item is serialized out as xml, its value is "dollarText".
  //[EnumString("dollarText")]
  DollarText,
  //
  // Summary:
  //     custom.
  //     When the item is serialized out as xml, its value is "custom".
  //[EnumString("custom")]
  Custom
}