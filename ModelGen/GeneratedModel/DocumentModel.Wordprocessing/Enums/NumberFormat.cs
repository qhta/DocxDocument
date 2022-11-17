namespace DocumentModel.Wordprocessing;

public enum NumberFormat
{

  [XmlEnum("decimal")]
  Decimal,

  [XmlEnum("upperRoman")]
  UpperRoman,

  [XmlEnum("lowerRoman")]
  LowerRoman,

  [XmlEnum("upperLetter")]
  UpperLetter,

  [XmlEnum("lowerLetter")]
  LowerLetter,

  [XmlEnum("ordinal")]
  Ordinal,

  [XmlEnum("cardinalText")]
  CardinalText,

  [XmlEnum("ordinalText")]
  OrdinalText,

  [XmlEnum("hex")]
  Hex,

  [XmlEnum("chicago")]
  Chicago,

  [XmlEnum("ideographDigital")]
  IdeographDigital,

  [XmlEnum("japaneseCounting")]
  JapaneseCounting,

  [XmlEnum("aiueo")]
  Aiueo,

  [XmlEnum("iroha")]
  Iroha,

  [XmlEnum("decimalFullWidth")]
  DecimalFullWidth,

  [XmlEnum("decimalHalfWidth")]
  DecimalHalfWidth,

  [XmlEnum("japaneseLegal")]
  JapaneseLegal,

  [XmlEnum("japaneseDigitalTenThousand")]
  JapaneseDigitalTenThousand,

  [XmlEnum("decimalEnclosedCircle")]
  DecimalEnclosedCircle,

  [XmlEnum("decimalFullWidth2")]
  DecimalFullWidth2,

  [XmlEnum("aiueoFullWidth")]
  AiueoFullWidth,

  [XmlEnum("irohaFullWidth")]
  IrohaFullWidth,

  [XmlEnum("decimalZero")]
  DecimalZero,

  [XmlEnum("bullet")]
  Bullet,

  [XmlEnum("ganada")]
  Ganada,

  [XmlEnum("chosung")]
  Chosung,

  [XmlEnum("decimalEnclosedFullstop")]
  DecimalEnclosedFullstop,

  [XmlEnum("decimalEnclosedParen")]
  DecimalEnclosedParen,

  [XmlEnum("decimalEnclosedCircleChinese")]
  DecimalEnclosedCircleChinese,

  [XmlEnum("ideographEnclosedCircle")]
  IdeographEnclosedCircle,

  [XmlEnum("ideographTraditional")]
  IdeographTraditional,

  [XmlEnum("ideographZodiac")]
  IdeographZodiac,

  [XmlEnum("ideographZodiacTraditional")]
  IdeographZodiacTraditional,

  [XmlEnum("taiwaneseCounting")]
  TaiwaneseCounting,

  [XmlEnum("ideographLegalTraditional")]
  IdeographLegalTraditional,

  [XmlEnum("taiwaneseCountingThousand")]
  TaiwaneseCountingThousand,

  [XmlEnum("taiwaneseDigital")]
  TaiwaneseDigital,

  [XmlEnum("chineseCounting")]
  ChineseCounting,

  [XmlEnum("chineseLegalSimplified")]
  ChineseLegalSimplified,

  [XmlEnum("chineseCountingThousand")]
  ChineseCountingThousand,

  [XmlEnum("koreanDigital")]
  KoreanDigital,

  [XmlEnum("koreanCounting")]
  KoreanCounting,

  [XmlEnum("koreanLegal")]
  KoreanLegal,

  [XmlEnum("koreanDigital2")]
  KoreanDigital2,

  [XmlEnum("vietnameseCounting")]
  VietnameseCounting,

  [XmlEnum("russianLower")]
  RussianLower,

  [XmlEnum("russianUpper")]
  RussianUpper,

  [XmlEnum("none")]
  None,

  [XmlEnum("numberInDash")]
  NumberInDash,

  [XmlEnum("hebrew1")]
  Hebrew1,

  [XmlEnum("hebrew2")]
  Hebrew2,

  [XmlEnum("arabicAlpha")]
  ArabicAlpha,

  [XmlEnum("arabicAbjad")]
  ArabicAbjad,

  [XmlEnum("hindiVowels")]
  HindiVowels,

  [XmlEnum("hindiConsonants")]
  HindiConsonants,

  [XmlEnum("hindiNumbers")]
  HindiNumbers,

  [XmlEnum("hindiCounting")]
  HindiCounting,

  [XmlEnum("thaiLetters")]
  ThaiLetters,

  [XmlEnum("thaiNumbers")]
  ThaiNumbers,

  [XmlEnum("thaiCounting")]
  ThaiCounting,

  [XmlEnum("bahtText")]
  BahtText,

  [XmlEnum("dollarText")]
  DollarText,

  [XmlEnum("custom")]
  Custom,
}
