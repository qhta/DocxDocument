namespace DocumentModel.Drawings;


/// <summary>
///   Text Auto-number Schemes
/// </summary>
public enum TextAutoNumberSchemeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaLcParenBoth&quot;.
  /// </summary>
  AlphaLowerCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaUcParenBoth&quot;.
  /// </summary>
  AlphaUpperCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaLcParenR&quot;.
  /// </summary>
  AlphaLowerCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaUcParenR&quot;.
  /// </summary>
  AlphaUpperCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaLcPeriod&quot;.
  /// </summary>
  AlphaLowerCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alphaUcPeriod&quot;.
  /// </summary>
  AlphaUpperCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicParenBoth&quot;.
  /// </summary>
  ArabicParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicParenR&quot;.
  /// </summary>
  ArabicParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicPeriod&quot;.
  /// </summary>
  ArabicPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicPlain&quot;.
  /// </summary>
  ArabicPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanLcParenBoth&quot;.
  /// </summary>
  RomanLowerCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanUcParenBoth&quot;.
  /// </summary>
  RomanUpperCharacterParenBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanLcParenR&quot;.
  /// </summary>
  RomanLowerCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanUcParenR&quot;.
  /// </summary>
  RomanUpperCharacterParenR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanLcPeriod&quot;.
  /// </summary>
  RomanLowerCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;romanUcPeriod&quot;.
  /// </summary>
  RomanUpperCharacterPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circleNumDbPlain&quot;.
  /// </summary>
  CircleNumberDoubleBytePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circleNumWdBlackPlain&quot;.
  /// </summary>
  CircleNumberWingdingsBlackPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circleNumWdWhitePlain&quot;.
  /// </summary>
  CircleNumberWingdingsWhitePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicDbPeriod&quot;.
  /// </summary>
  ArabicDoubleBytePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabicDbPlain&quot;.
  /// </summary>
  ArabicDoubleBytePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChsPeriod&quot;.
  /// </summary>
  EastAsianSimplifiedChinesePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChsPlain&quot;.
  /// </summary>
  EastAsianSimplifiedChinesePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChtPeriod&quot;.
  /// </summary>
  EastAsianTraditionalChinesePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1ChtPlain&quot;.
  /// </summary>
  EastAsianTraditionalChinesePlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1JpnChsDbPeriod&quot;.
  /// </summary>
  EastAsianJapaneseDoubleBytePeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1JpnKorPlain&quot;.
  /// </summary>
  EastAsianJapaneseKoreanPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ea1JpnKorPeriod&quot;.
  /// </summary>
  EastAsianJapaneseKoreanPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabic1Minus&quot;.
  /// </summary>
  Arabic1Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arabic2Minus&quot;.
  /// </summary>
  Arabic2Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hebrew2Minus&quot;.
  /// </summary>
  Hebrew2Minus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiAlphaPeriod&quot;.
  /// </summary>
  ThaiAlphaPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiAlphaParenR&quot;.
  /// </summary>
  ThaiAlphaParenthesisRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiAlphaParenBoth&quot;.
  /// </summary>
  ThaiAlphaParenthesisBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumPeriod&quot;.
  /// </summary>
  ThaiNumberPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumParenR&quot;.
  /// </summary>
  ThaiNumberParenthesisRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thaiNumParenBoth&quot;.
  /// </summary>
  ThaiNumberParenthesisBoth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiAlphaPeriod&quot;.
  /// </summary>
  HindiAlphaPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiNumPeriod&quot;.
  /// </summary>
  HindiNumPeriod,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiNumParenR&quot;.
  /// </summary>
  HindiNumberParenthesisRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hindiAlpha1Period&quot;.
  /// </summary>
  HindiAlpha1Period,
  
}
