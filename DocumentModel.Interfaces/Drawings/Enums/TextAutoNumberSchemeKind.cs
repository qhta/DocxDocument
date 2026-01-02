namespace DocumentModel.Drawings;

/// <summary>
///   Text Auto-number Schemes
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextAutoNumberSchemeKind
{
  /// <summary>
  ///   Autonumber Enum ( alphaLcParenBoth ).
  /// </summary>
  AlphaLowerCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcParenBoth ).
  /// </summary>
  AlphaUpperCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( alphaLcParenR ).
  /// </summary>
  AlphaLowerCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcParenR ).
  /// </summary>
  AlphaUpperCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( alphaLcPeriod ).
  /// </summary>
  AlphaLowerCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcPeriod ).
  /// </summary>
  AlphaUpperCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicParenBoth ).
  /// </summary>
  ArabicParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( arabicParenR ).
  /// </summary>
  ArabicParenR,
  /// <summary>
  ///   Autonumbering Enum ( arabicPeriod ).
  /// </summary>
  ArabicPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicPlain ).
  /// </summary>
  ArabicPlain,
  /// <summary>
  ///   Autonumbering Enum ( romanLcParenBoth ).
  /// </summary>
  RomanLowerCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( romanUcParenBoth ).
  /// </summary>
  RomanUpperCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( romanLcParenR ).
  /// </summary>
  RomanLowerCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( romanUcParenR ).
  /// </summary>
  RomanUpperCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( romanLcPeriod ).
  /// </summary>
  RomanLowerCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( romanUcPeriod ).
  /// </summary>
  RomanUpperCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( circleNumDbPlain ).
  /// </summary>
  CircleNumberDoubleBytePlain,
  /// <summary>
  ///   Autonumbering Enum ( circleNumWdBlackPlain ).
  /// </summary>
  CircleNumberWingdingsBlackPlain,
  /// <summary>
  ///   Autonumbering Enum ( circleNumWdWhitePlain ).
  /// </summary>
  CircleNumberWingdingsWhitePlain,
  /// <summary>
  ///   Autonumbering Enum ( arabicDbPeriod ).
  /// </summary>
  ArabicDoubleBytePeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicDbPlain ).
  /// </summary>
  ArabicDoubleBytePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChsPeriod ).
  /// </summary>
  EastAsianSimplifiedChinesePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChsPlain ).
  /// </summary>
  EastAsianSimplifiedChinesePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChtPeriod ).
  /// </summary>
  EastAsianTraditionalChinesePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChtPlain ).
  /// </summary>
  EastAsianTraditionalChinesePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnChsDbPeriod ).
  /// </summary>
  EastAsianJapaneseDoubleBytePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnKorPlain ).
  /// </summary>
  EastAsianJapaneseKoreanPlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnKorPeriod ).
  /// </summary>
  EastAsianJapaneseKoreanPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabic1Minus ).
  /// </summary>
  Arabic1Minus,
  /// <summary>
  ///   Autonumbering Enum ( arabic2Minus ).
  /// </summary>
  Arabic2Minus,
  /// <summary>
  ///   Autonumbering Enum ( hebrew2Minus ).
  /// </summary>
  Hebrew2Minus,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaPeriod ).
  /// </summary>
  ThaiAlphaPeriod,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaParenR ).
  /// </summary>
  ThaiAlphaParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaParenBoth ).
  /// </summary>
  ThaiAlphaParenthesisBoth,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumPeriod ).
  /// </summary>
  ThaiNumberPeriod,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumParenR ).
  /// </summary>
  ThaiNumberParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumParenBoth ).
  /// </summary>
  ThaiNumberParenthesisBoth,
  /// <summary>
  ///   Autonumbering Enum ( hindiAlphaPeriod ).
  /// </summary>
  HindiAlphaPeriod,
  /// <summary>
  ///   Autonumbering Enum ( hindiNumPeriod ).
  /// </summary>
  HindiNumPeriod,
  /// <summary>
  ///   Autonumbering Enum ( hindiNumParenR ).
  /// </summary>
  HindiNumberParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( hindiAlpha1Period ).
  /// </summary>
  HindiAlpha1Period
}