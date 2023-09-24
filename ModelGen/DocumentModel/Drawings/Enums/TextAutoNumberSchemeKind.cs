namespace DocumentModel.Drawings;


/// <summary>
///   Text Auto-number Schemes
/// </summary>
public enum TextAutoNumberSchemeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaLcParenBoth&quot;.
  /// </summary>
  [EnumString("alphaLcParenBoth")]
  AlphaLowerCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaUcParenBoth&quot;.
  /// </summary>
  [EnumString("alphaUcParenBoth")]
  AlphaUpperCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaLcParenR&quot;.
  /// </summary>
  [EnumString("alphaLcParenR")]
  AlphaLowerCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaUcParenR&quot;.
  /// </summary>
  [EnumString("alphaUcParenR")]
  AlphaUpperCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaLcPeriod&quot;.
  /// </summary>
  [EnumString("alphaLcPeriod")]
  AlphaLowerCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaUcPeriod&quot;.
  /// </summary>
  [EnumString("alphaUcPeriod")]
  AlphaUpperCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicParenBoth&quot;.
  /// </summary>
  [EnumString("arabicParenBoth")]
  ArabicParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicParenR&quot;.
  /// </summary>
  [EnumString("arabicParenR")]
  ArabicParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicPeriod&quot;.
  /// </summary>
  [EnumString("arabicPeriod")]
  ArabicPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicPlain&quot;.
  /// </summary>
  [EnumString("arabicPlain")]
  ArabicPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanLcParenBoth&quot;.
  /// </summary>
  [EnumString("romanLcParenBoth")]
  RomanLowerCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanUcParenBoth&quot;.
  /// </summary>
  [EnumString("romanUcParenBoth")]
  RomanUpperCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanLcParenR&quot;.
  /// </summary>
  [EnumString("romanLcParenR")]
  RomanLowerCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanUcParenR&quot;.
  /// </summary>
  [EnumString("romanUcParenR")]
  RomanUpperCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanLcPeriod&quot;.
  /// </summary>
  [EnumString("romanLcPeriod")]
  RomanLowerCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanUcPeriod&quot;.
  /// </summary>
  [EnumString("romanUcPeriod")]
  RomanUpperCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circleNumDbPlain&quot;.
  /// </summary>
  [EnumString("circleNumDbPlain")]
  CircleNumberDoubleBytePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circleNumWdBlackPlain&quot;.
  /// </summary>
  [EnumString("circleNumWdBlackPlain")]
  CircleNumberWingdingsBlackPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circleNumWdWhitePlain&quot;.
  /// </summary>
  [EnumString("circleNumWdWhitePlain")]
  CircleNumberWingdingsWhitePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicDbPeriod&quot;.
  /// </summary>
  [EnumString("arabicDbPeriod")]
  ArabicDoubleBytePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicDbPlain&quot;.
  /// </summary>
  [EnumString("arabicDbPlain")]
  ArabicDoubleBytePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChsPeriod&quot;.
  /// </summary>
  [EnumString("ea1ChsPeriod")]
  EastAsianSimplifiedChinesePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChsPlain&quot;.
  /// </summary>
  [EnumString("ea1ChsPlain")]
  EastAsianSimplifiedChinesePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChtPeriod&quot;.
  /// </summary>
  [EnumString("ea1ChtPeriod")]
  EastAsianTraditionalChinesePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChtPlain&quot;.
  /// </summary>
  [EnumString("ea1ChtPlain")]
  EastAsianTraditionalChinesePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1JpnChsDbPeriod&quot;.
  /// </summary>
  [EnumString("ea1JpnChsDbPeriod")]
  EastAsianJapaneseDoubleBytePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1JpnKorPlain&quot;.
  /// </summary>
  [EnumString("ea1JpnKorPlain")]
  EastAsianJapaneseKoreanPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1JpnKorPeriod&quot;.
  /// </summary>
  [EnumString("ea1JpnKorPeriod")]
  EastAsianJapaneseKoreanPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabic1Minus&quot;.
  /// </summary>
  [EnumString("arabic1Minus")]
  Arabic1Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabic2Minus&quot;.
  /// </summary>
  [EnumString("arabic2Minus")]
  Arabic2Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hebrew2Minus&quot;.
  /// </summary>
  [EnumString("hebrew2Minus")]
  Hebrew2Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiAlphaPeriod&quot;.
  /// </summary>
  [EnumString("thaiAlphaPeriod")]
  ThaiAlphaPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiAlphaParenR&quot;.
  /// </summary>
  [EnumString("thaiAlphaParenR")]
  ThaiAlphaParenthesisRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiAlphaParenBoth&quot;.
  /// </summary>
  [EnumString("thaiAlphaParenBoth")]
  ThaiAlphaParenthesisBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumPeriod&quot;.
  /// </summary>
  [EnumString("thaiNumPeriod")]
  ThaiNumberPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumParenR&quot;.
  /// </summary>
  [EnumString("thaiNumParenR")]
  ThaiNumberParenthesisRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumParenBoth&quot;.
  /// </summary>
  [EnumString("thaiNumParenBoth")]
  ThaiNumberParenthesisBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiAlphaPeriod&quot;.
  /// </summary>
  [EnumString("hindiAlphaPeriod")]
  HindiAlphaPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiNumPeriod&quot;.
  /// </summary>
  [EnumString("hindiNumPeriod")]
  HindiNumPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiNumParenR&quot;.
  /// </summary>
  [EnumString("hindiNumParenR")]
  HindiNumberParenthesisRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiAlpha1Period&quot;.
  /// </summary>
  [EnumString("hindiAlpha1Period")]
  HindiAlpha1Period,
  
}
