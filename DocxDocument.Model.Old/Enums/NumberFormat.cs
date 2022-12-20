namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum NumberFormat
{
  /// <summary> 
  /// Decimal Numbers
  ///</summary> 
  Decimal = 0,
  /// <summary> 
  /// Uppercase Roman Numerals
  ///</summary> 
  UpperRoman = 1,
  /// <summary> 
  /// Lowercase Roman Numerals
  ///</summary> 
  LowerRoman = 2,
  /// <summary> 
  /// Uppercase Latin Alphabet
  ///</summary> 
  UpperLetter = 3,
  /// <summary> 
  /// Lowercase Latin Alphabet
  ///</summary> 
  LowerLetter = 4,
  /// <summary> 
  /// Ordinal
  ///</summary> 
  Ordinal = 5,
  /// <summary> 
  /// Cardinal Text
  ///</summary> 
  CardinalText = 6,
  /// <summary> 
  /// Ordinal Text
  ///</summary> 
  OrdinalText = 7,
  /// <summary> 
  /// Hexadecimal Numbering
  ///</summary> 
  Hex = 8,
  /// <summary> 
  /// Chicago Manual of Style
  ///</summary> 
  Chicago = 9,
  /// <summary> 
  /// Ideographs
  ///</summary> 
  IdeographDigital = 10,
  /// <summary> 
  /// Japanese Counting System
  ///</summary> 
  JapaneseCounting = 11,
  /// <summary> 
  /// AIUEO Order Hiragana
  ///</summary> 
  Aiueo = 12,
  /// <summary> 
  /// Iroha Ordered Katakana
  ///</summary> 
  Iroha = 13,
  /// <summary> 
  /// Double Byte Arabic Numerals
  ///</summary> 
  DecimalFullWidth = 14,
  /// <summary> 
  /// Single Byte Arabic Numerals
  ///</summary> 
  DecimalHalfWidth = 15,
  /// <summary> 
  /// Japanese Legal Numbering
  ///</summary> 
  JapaneseLegal = 16,
  /// <summary> 
  /// Japanese Digital Ten Thousand Counting System
  ///</summary> 
  JapaneseDigitalTenThousand = 17,
  /// <summary> 
  /// Decimal Numbers Enclosed in a Circle
  ///</summary> 
  DecimalEnclosedCircle = 18,
  /// <summary> 
  /// Double Byte Arabic Numerals Alternate
  ///</summary> 
  DecimalFullWidth2 = 19,
  /// <summary> 
  /// Full-Width AIUEO Order Hiragana
  ///</summary> 
  AiueoFullWidth = 20,
  /// <summary> 
  /// Full-Width Iroha Ordered Katakana
  ///</summary> 
  IrohaFullWidth = 21,
  /// <summary> 
  /// Initial Zero Arabic Numerals
  ///</summary> 
  DecimalZero = 22,
  /// <summary> 
  /// Bullet
  ///</summary> 
  Bullet = 23,
  /// <summary> 
  /// Korean Ganada Numbering
  ///</summary> 
  Ganada = 24,
  /// <summary> 
  /// Korean Chosung Numbering
  ///</summary> 
  Chosung = 25,
  /// <summary> 
  /// Decimal Numbers Followed by a Period
  ///</summary> 
  DecimalEnclosedFullstop = 26,
  /// <summary> 
  /// Decimal Numbers Enclosed in Parenthesis
  ///</summary> 
  DecimalEnclosedParen = 27,
  /// <summary> 
  /// Decimal Numbers Enclosed in a Circle
  ///</summary> 
  DecimalEnclosedCircleChinese = 28,
  /// <summary> 
  /// Ideographs Enclosed in a Circle
  ///</summary> 
  IdeographEnclosedCircle = 29,
  /// <summary> 
  /// Traditional Ideograph Format
  ///</summary> 
  IdeographTraditional = 30,
  /// <summary> 
  /// Zodiac Ideograph Format
  ///</summary> 
  IdeographZodiac = 31,
  /// <summary> 
  /// Traditional Zodiac Ideograph Format
  ///</summary> 
  IdeographZodiacTraditional = 32,
  /// <summary> 
  /// Taiwanese Counting System
  ///</summary> 
  TaiwaneseCounting = 33,
  /// <summary> 
  /// Traditional Legal Ideograph Format
  ///</summary> 
  IdeographLegalTraditional = 34,
  /// <summary> 
  /// Taiwanese Counting Thousand System
  ///</summary> 
  TaiwaneseCountingThousand = 35,
  /// <summary> 
  /// Taiwanese Digital Counting System
  ///</summary> 
  TaiwaneseDigital = 36,
  /// <summary> 
  /// Chinese Counting System
  ///</summary> 
  ChineseCounting = 37,
  /// <summary> 
  /// Chinese Legal Simplified Format
  ///</summary> 
  ChineseLegalSimplified = 38,
  /// <summary> 
  /// Chinese Counting Thousand System
  ///</summary> 
  ChineseCountingThousand = 39,
  /// <summary> 
  /// Korean Digital Counting System
  ///</summary> 
  KoreanDigital = 40,
  /// <summary> 
  /// Korean Counting System
  ///</summary> 
  KoreanCounting = 41,
  /// <summary> 
  /// Korean Legal Numbering
  ///</summary> 
  KoreanLegal = 42,
  /// <summary> 
  /// Korean Digital Counting System Alternate
  ///</summary> 
  KoreanDigital2 = 43,
  /// <summary> 
  /// Vietnamese Numerals
  ///</summary> 
  VietnameseCounting = 44,
  /// <summary> 
  /// Lowercase Russian Alphabet
  ///</summary> 
  RussianLower = 45,
  /// <summary> 
  /// Uppercase Russian Alphabet
  ///</summary> 
  RussianUpper = 46,
  /// <summary> 
  /// No Numbering
  ///</summary> 
  None = 47,
  /// <summary> 
  /// Number With Dashes
  ///</summary> 
  NumberInDash = 48,
  /// <summary> 
  /// Hebrew Numerals
  ///</summary> 
  Hebrew1 = 49,
  /// <summary> 
  /// Hebrew Alphabet
  ///</summary> 
  Hebrew2 = 50,
  /// <summary> 
  /// Arabic Alphabet
  ///</summary> 
  ArabicAlpha = 51,
  /// <summary> 
  /// Arabic Abjad Numerals
  ///</summary> 
  ArabicAbjad = 52,
  /// <summary> 
  /// Hindi Vowels
  ///</summary> 
  HindiVowels = 53,
  /// <summary> 
  /// Hindi Consonants
  ///</summary> 
  HindiConsonants = 54,
  /// <summary> 
  /// Hindi Numbers
  ///</summary> 
  HindiNumbers = 55,
  /// <summary> 
  /// Hindi Counting System
  ///</summary> 
  HindiCounting = 56,
  /// <summary> 
  /// Thai Letters
  ///</summary> 
  ThaiLetters = 57,
  /// <summary> 
  /// Thai Numerals
  ///</summary> 
  ThaiNumbers = 58,
  /// <summary> 
  /// Thai Counting System
  ///</summary> 
  ThaiCounting = 59,
  /// <summary> 
  /// bahtText
  ///</summary> 
  BahtText = 60,
  /// <summary> 
  /// dollarText
  ///</summary> 
  DollarText = 61,
  /// <summary> 
  /// custom
  ///</summary> 
  Custom = 62,


}