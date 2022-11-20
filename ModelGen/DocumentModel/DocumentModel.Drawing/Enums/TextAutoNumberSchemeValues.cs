namespace DocumentModel.Drawing;

/// <summary>
/// Text Auto-number Schemes
/// </summary>
public enum TextAutoNumberSchemeValues
{
  /// <summary>
  /// Autonumber Enum ( alphaLcParenBoth ).
  /// </summary>
  [XmlEnum("alphaLcParenBoth")]
  AlphaLowerCharacterParenBoth,
  
  /// <summary>
  /// Autonumbering Enum ( alphaUcParenBoth ).
  /// </summary>
  [XmlEnum("alphaUcParenBoth")]
  AlphaUpperCharacterParenBoth,
  
  /// <summary>
  /// Autonumbering Enum ( alphaLcParenR ).
  /// </summary>
  [XmlEnum("alphaLcParenR")]
  AlphaLowerCharacterParenR,
  
  /// <summary>
  /// Autonumbering Enum ( alphaUcParenR ).
  /// </summary>
  [XmlEnum("alphaUcParenR")]
  AlphaUpperCharacterParenR,
  
  /// <summary>
  /// Autonumbering Enum ( alphaLcPeriod ).
  /// </summary>
  [XmlEnum("alphaLcPeriod")]
  AlphaLowerCharacterPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( alphaUcPeriod ).
  /// </summary>
  [XmlEnum("alphaUcPeriod")]
  AlphaUpperCharacterPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( arabicParenBoth ).
  /// </summary>
  [XmlEnum("arabicParenBoth")]
  ArabicParenBoth,
  
  /// <summary>
  /// Autonumbering Enum ( arabicParenR ).
  /// </summary>
  [XmlEnum("arabicParenR")]
  ArabicParenR,
  
  /// <summary>
  /// Autonumbering Enum ( arabicPeriod ).
  /// </summary>
  [XmlEnum("arabicPeriod")]
  ArabicPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( arabicPlain ).
  /// </summary>
  [XmlEnum("arabicPlain")]
  ArabicPlain,
  
  /// <summary>
  /// Autonumbering Enum ( romanLcParenBoth ).
  /// </summary>
  [XmlEnum("romanLcParenBoth")]
  RomanLowerCharacterParenBoth,
  
  /// <summary>
  /// Autonumbering Enum ( romanUcParenBoth ).
  /// </summary>
  [XmlEnum("romanUcParenBoth")]
  RomanUpperCharacterParenBoth,
  
  /// <summary>
  /// Autonumbering Enum ( romanLcParenR ).
  /// </summary>
  [XmlEnum("romanLcParenR")]
  RomanLowerCharacterParenR,
  
  /// <summary>
  /// Autonumbering Enum ( romanUcParenR ).
  /// </summary>
  [XmlEnum("romanUcParenR")]
  RomanUpperCharacterParenR,
  
  /// <summary>
  /// Autonumbering Enum ( romanLcPeriod ).
  /// </summary>
  [XmlEnum("romanLcPeriod")]
  RomanLowerCharacterPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( romanUcPeriod ).
  /// </summary>
  [XmlEnum("romanUcPeriod")]
  RomanUpperCharacterPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( circleNumDbPlain ).
  /// </summary>
  [XmlEnum("circleNumDbPlain")]
  CircleNumberDoubleBytePlain,
  
  /// <summary>
  /// Autonumbering Enum ( circleNumWdBlackPlain ).
  /// </summary>
  [XmlEnum("circleNumWdBlackPlain")]
  CircleNumberWingdingsBlackPlain,
  
  /// <summary>
  /// Autonumbering Enum ( circleNumWdWhitePlain ).
  /// </summary>
  [XmlEnum("circleNumWdWhitePlain")]
  CircleNumberWingdingsWhitePlain,
  
  /// <summary>
  /// Autonumbering Enum ( arabicDbPeriod ).
  /// </summary>
  [XmlEnum("arabicDbPeriod")]
  ArabicDoubleBytePeriod,
  
  /// <summary>
  /// Autonumbering Enum ( arabicDbPlain ).
  /// </summary>
  [XmlEnum("arabicDbPlain")]
  ArabicDoubleBytePlain,
  
  /// <summary>
  /// Autonumbering Enum ( ea1ChsPeriod ).
  /// </summary>
  [XmlEnum("ea1ChsPeriod")]
  EastAsianSimplifiedChinesePeriod,
  
  /// <summary>
  /// Autonumbering Enum ( ea1ChsPlain ).
  /// </summary>
  [XmlEnum("ea1ChsPlain")]
  EastAsianSimplifiedChinesePlain,
  
  /// <summary>
  /// Autonumbering Enum ( ea1ChtPeriod ).
  /// </summary>
  [XmlEnum("ea1ChtPeriod")]
  EastAsianTraditionalChinesePeriod,
  
  /// <summary>
  /// Autonumbering Enum ( ea1ChtPlain ).
  /// </summary>
  [XmlEnum("ea1ChtPlain")]
  EastAsianTraditionalChinesePlain,
  
  /// <summary>
  /// Autonumbering Enum ( ea1JpnChsDbPeriod ).
  /// </summary>
  [XmlEnum("ea1JpnChsDbPeriod")]
  EastAsianJapaneseDoubleBytePeriod,
  
  /// <summary>
  /// Autonumbering Enum ( ea1JpnKorPlain ).
  /// </summary>
  [XmlEnum("ea1JpnKorPlain")]
  EastAsianJapaneseKoreanPlain,
  
  /// <summary>
  /// Autonumbering Enum ( ea1JpnKorPeriod ).
  /// </summary>
  [XmlEnum("ea1JpnKorPeriod")]
  EastAsianJapaneseKoreanPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( arabic1Minus ).
  /// </summary>
  [XmlEnum("arabic1Minus")]
  Arabic1Minus,
  
  /// <summary>
  /// Autonumbering Enum ( arabic2Minus ).
  /// </summary>
  [XmlEnum("arabic2Minus")]
  Arabic2Minus,
  
  /// <summary>
  /// Autonumbering Enum ( hebrew2Minus ).
  /// </summary>
  [XmlEnum("hebrew2Minus")]
  Hebrew2Minus,
  
  /// <summary>
  /// Autonumbering Enum ( thaiAlphaPeriod ).
  /// </summary>
  [XmlEnum("thaiAlphaPeriod")]
  ThaiAlphaPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( thaiAlphaParenR ).
  /// </summary>
  [XmlEnum("thaiAlphaParenR")]
  ThaiAlphaParenthesisRight,
  
  /// <summary>
  /// Autonumbering Enum ( thaiAlphaParenBoth ).
  /// </summary>
  [XmlEnum("thaiAlphaParenBoth")]
  ThaiAlphaParenthesisBoth,
  
  /// <summary>
  /// Autonumbering Enum ( thaiNumPeriod ).
  /// </summary>
  [XmlEnum("thaiNumPeriod")]
  ThaiNumberPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( thaiNumParenR ).
  /// </summary>
  [XmlEnum("thaiNumParenR")]
  ThaiNumberParenthesisRight,
  
  /// <summary>
  /// Autonumbering Enum ( thaiNumParenBoth ).
  /// </summary>
  [XmlEnum("thaiNumParenBoth")]
  ThaiNumberParenthesisBoth,
  
  /// <summary>
  /// Autonumbering Enum ( hindiAlphaPeriod ).
  /// </summary>
  [XmlEnum("hindiAlphaPeriod")]
  HindiAlphaPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( hindiNumPeriod ).
  /// </summary>
  [XmlEnum("hindiNumPeriod")]
  HindiNumPeriod,
  
  /// <summary>
  /// Autonumbering Enum ( hindiNumParenR ).
  /// </summary>
  [XmlEnum("hindiNumParenR")]
  HindiNumberParenthesisRight,
  
  /// <summary>
  /// Autonumbering Enum ( hindiAlpha1Period ).
  /// </summary>
  [XmlEnum("hindiAlpha1Period")]
  HindiAlpha1Period,
  
}
