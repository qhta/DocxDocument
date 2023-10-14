namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the NumberFormatValues enumeration.
/// </summary>
public enum NumberFormatKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimal&quot;.
  /// </summary>
  Decimal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upperRoman&quot;.
  /// </summary>
  UpperRoman,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lowerRoman&quot;.
  /// </summary>
  LowerRoman,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upperLetter&quot;.
  /// </summary>
  UpperLetter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lowerLetter&quot;.
  /// </summary>
  LowerLetter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ordinal&quot;.
  /// </summary>
  Ordinal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cardinalText&quot;.
  /// </summary>
  CardinalText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ordinalText&quot;.
  /// </summary>
  OrdinalText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hex&quot;.
  /// </summary>
  Hex,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chicago&quot;.
  /// </summary>
  Chicago,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ideographDigital&quot;.
  /// </summary>
  IdeographDigital,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;japaneseCounting&quot;.
  /// </summary>
  JapaneseCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;aiueo&quot;.
  /// </summary>
  Aiueo,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;iroha&quot;.
  /// </summary>
  Iroha,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalFullWidth&quot;.
  /// </summary>
  DecimalFullWidth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalHalfWidth&quot;.
  /// </summary>
  DecimalHalfWidth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;japaneseLegal&quot;.
  /// </summary>
  JapaneseLegal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;japaneseDigitalTenThousand&quot;.
  /// </summary>
  JapaneseDigitalTenThousand,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalEnclosedCircle&quot;.
  /// </summary>
  DecimalEnclosedCircle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalFullWidth2&quot;.
  /// </summary>
  DecimalFullWidth2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;aiueoFullWidth&quot;.
  /// </summary>
  AiueoFullWidth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;irohaFullWidth&quot;.
  /// </summary>
  IrohaFullWidth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalZero&quot;.
  /// </summary>
  DecimalZero,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bullet&quot;.
  /// </summary>
  Bullet,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ganada&quot;.
  /// </summary>
  Ganada,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chosung&quot;.
  /// </summary>
  Chosung,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalEnclosedFullstop&quot;.
  /// </summary>
  DecimalEnclosedFullstop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalEnclosedParen&quot;.
  /// </summary>
  DecimalEnclosedParen,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decimalEnclosedCircleChinese&quot;.
  /// </summary>
  DecimalEnclosedCircleChinese,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ideographEnclosedCircle&quot;.
  /// </summary>
  IdeographEnclosedCircle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ideographTraditional&quot;.
  /// </summary>
  IdeographTraditional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ideographZodiac&quot;.
  /// </summary>
  IdeographZodiac,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ideographZodiacTraditional&quot;.
  /// </summary>
  IdeographZodiacTraditional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;taiwaneseCounting&quot;.
  /// </summary>
  TaiwaneseCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ideographLegalTraditional&quot;.
  /// </summary>
  IdeographLegalTraditional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;taiwaneseCountingThousand&quot;.
  /// </summary>
  TaiwaneseCountingThousand,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;taiwaneseDigital&quot;.
  /// </summary>
  TaiwaneseDigital,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chineseCounting&quot;.
  /// </summary>
  ChineseCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chineseLegalSimplified&quot;.
  /// </summary>
  ChineseLegalSimplified,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chineseCountingThousand&quot;.
  /// </summary>
  ChineseCountingThousand,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;koreanDigital&quot;.
  /// </summary>
  KoreanDigital,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;koreanCounting&quot;.
  /// </summary>
  KoreanCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;koreanLegal&quot;.
  /// </summary>
  KoreanLegal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;koreanDigital2&quot;.
  /// </summary>
  KoreanDigital2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vietnameseCounting&quot;.
  /// </summary>
  VietnameseCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;russianLower&quot;.
  /// </summary>
  RussianLower,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;russianUpper&quot;.
  /// </summary>
  RussianUpper,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;numberInDash&quot;.
  /// </summary>
  NumberInDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hebrew1&quot;.
  /// </summary>
  Hebrew1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hebrew2&quot;.
  /// </summary>
  Hebrew2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicAlpha&quot;.
  /// </summary>
  ArabicAlpha,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicAbjad&quot;.
  /// </summary>
  ArabicAbjad,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiVowels&quot;.
  /// </summary>
  HindiVowels,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiConsonants&quot;.
  /// </summary>
  HindiConsonants,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiNumbers&quot;.
  /// </summary>
  HindiNumbers,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiCounting&quot;.
  /// </summary>
  HindiCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiLetters&quot;.
  /// </summary>
  ThaiLetters,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumbers&quot;.
  /// </summary>
  ThaiNumbers,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiCounting&quot;.
  /// </summary>
  ThaiCounting,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bahtText&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  BahtText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dollarText&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  DollarText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;. This item is only available in Office 2010 and later.
  /// </summary>
  Custom,
  
}
