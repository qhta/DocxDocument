namespace DocumentModel.Drawings;
/// <summary>
///   Text Auto-number Schemes
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextAutoNumberSchemeValues))]
public enum TextAutoNumberSchemeKind
{
  /// <summary>
  ///   Autonumber Enum ( alphaLcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.AlphaLowerCharacterParenBoth))]
  AlphaLowerCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.AlphaUpperCharacterParenBoth))]
  AlphaUpperCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( alphaLcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.AlphaLowerCharacterParenR))]
  AlphaLowerCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.AlphaUpperCharacterParenR))]
  AlphaUpperCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( alphaLcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.AlphaLowerCharacterPeriod))]
  AlphaLowerCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.AlphaUpperCharacterPeriod))]
  AlphaUpperCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ArabicParenBoth))]
  ArabicParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( arabicParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ArabicParenR))]
  ArabicParenR,
  /// <summary>
  ///   Autonumbering Enum ( arabicPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ArabicPeriod))]
  ArabicPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ArabicPlain))]
  ArabicPlain,
  /// <summary>
  ///   Autonumbering Enum ( romanLcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.RomanLowerCharacterParenBoth))]
  RomanLowerCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( romanUcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.RomanUpperCharacterParenBoth))]
  RomanUpperCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( romanLcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.RomanLowerCharacterParenR))]
  RomanLowerCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( romanUcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.RomanUpperCharacterParenR))]
  RomanUpperCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( romanLcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.RomanLowerCharacterPeriod))]
  RomanLowerCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( romanUcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.RomanUpperCharacterPeriod))]
  RomanUpperCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( circleNumDbPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.CircleNumberDoubleBytePlain))]
  CircleNumberDoubleBytePlain,
  /// <summary>
  ///   Autonumbering Enum ( circleNumWdBlackPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.CircleNumberWingdingsBlackPlain))]
  CircleNumberWingdingsBlackPlain,
  /// <summary>
  ///   Autonumbering Enum ( circleNumWdWhitePlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.CircleNumberWingdingsWhitePlain))]
  CircleNumberWingdingsWhitePlain,
  /// <summary>
  ///   Autonumbering Enum ( arabicDbPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ArabicDoubleBytePeriod))]
  ArabicDoubleBytePeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicDbPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ArabicDoubleBytePlain))]
  ArabicDoubleBytePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChsPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianSimplifiedChinesePeriod))]
  EastAsianSimplifiedChinesePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChsPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianSimplifiedChinesePlain))]
  EastAsianSimplifiedChinesePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChtPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianTraditionalChinesePeriod))]
  EastAsianTraditionalChinesePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChtPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianTraditionalChinesePlain))]
  EastAsianTraditionalChinesePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnChsDbPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianJapaneseDoubleBytePeriod))]
  EastAsianJapaneseDoubleBytePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnKorPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianJapaneseKoreanPlain))]
  EastAsianJapaneseKoreanPlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnKorPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.EastAsianJapaneseKoreanPeriod))]
  EastAsianJapaneseKoreanPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabic1Minus ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.Arabic1Minus))]
  Arabic1Minus,
  /// <summary>
  ///   Autonumbering Enum ( arabic2Minus ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.Arabic2Minus))]
  Arabic2Minus,
  /// <summary>
  ///   Autonumbering Enum ( hebrew2Minus ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.Hebrew2Minus))]
  Hebrew2Minus,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ThaiAlphaPeriod))]
  ThaiAlphaPeriod,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ThaiAlphaParenthesisRight))]
  ThaiAlphaParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ThaiAlphaParenthesisBoth))]
  ThaiAlphaParenthesisBoth,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ThaiNumberPeriod))]
  ThaiNumberPeriod,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ThaiNumberParenthesisRight))]
  ThaiNumberParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.ThaiNumberParenthesisBoth))]
  ThaiNumberParenthesisBoth,
  /// <summary>
  ///   Autonumbering Enum ( hindiAlphaPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.HindiAlphaPeriod))]
  HindiAlphaPeriod,
  /// <summary>
  ///   Autonumbering Enum ( hindiNumPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.HindiNumPeriod))]
  HindiNumPeriod,
  /// <summary>
  ///   Autonumbering Enum ( hindiNumParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.HindiNumberParenthesisRight))]
  HindiNumberParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( hindiAlpha1Period ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAutoNumberSchemeValues.HindiAlpha1Period))]
  HindiAlpha1Period
}