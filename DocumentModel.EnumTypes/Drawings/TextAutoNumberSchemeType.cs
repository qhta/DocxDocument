namespace DocumentModel.Drawings;
/// <summary>
///   Text Auto-number Schemes
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues))]
public enum TextAutoNumberSchemeType
{
  /// <summary>
  ///   Autonumber Enum ( alphaLcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.AlphaLowerCharacterParenBoth))]
  AlphaLowerCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.AlphaUpperCharacterParenBoth))]
  AlphaUpperCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( alphaLcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.AlphaLowerCharacterParenR))]
  AlphaLowerCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.AlphaUpperCharacterParenR))]
  AlphaUpperCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( alphaLcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.AlphaLowerCharacterPeriod))]
  AlphaLowerCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( alphaUcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.AlphaUpperCharacterPeriod))]
  AlphaUpperCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ArabicParenBoth))]
  ArabicParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( arabicParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ArabicParenR))]
  ArabicParenR,
  /// <summary>
  ///   Autonumbering Enum ( arabicPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ArabicPeriod))]
  ArabicPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ArabicPlain))]
  ArabicPlain,
  /// <summary>
  ///   Autonumbering Enum ( romanLcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.RomanLowerCharacterParenBoth))]
  RomanLowerCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( romanUcParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.RomanUpperCharacterParenBoth))]
  RomanUpperCharacterParenBoth,
  /// <summary>
  ///   Autonumbering Enum ( romanLcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.RomanLowerCharacterParenR))]
  RomanLowerCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( romanUcParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.RomanUpperCharacterParenR))]
  RomanUpperCharacterParenR,
  /// <summary>
  ///   Autonumbering Enum ( romanLcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.RomanLowerCharacterPeriod))]
  RomanLowerCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( romanUcPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.RomanUpperCharacterPeriod))]
  RomanUpperCharacterPeriod,
  /// <summary>
  ///   Autonumbering Enum ( circleNumDbPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.CircleNumberDoubleBytePlain))]
  CircleNumberDoubleBytePlain,
  /// <summary>
  ///   Autonumbering Enum ( circleNumWdBlackPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.CircleNumberWingdingsBlackPlain))]
  CircleNumberWingdingsBlackPlain,
  /// <summary>
  ///   Autonumbering Enum ( circleNumWdWhitePlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.CircleNumberWingdingsWhitePlain))]
  CircleNumberWingdingsWhitePlain,
  /// <summary>
  ///   Autonumbering Enum ( arabicDbPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ArabicDoubleBytePeriod))]
  ArabicDoubleBytePeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabicDbPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ArabicDoubleBytePlain))]
  ArabicDoubleBytePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChsPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianSimplifiedChinesePeriod))]
  EastAsianSimplifiedChinesePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChsPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianSimplifiedChinesePlain))]
  EastAsianSimplifiedChinesePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChtPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianTraditionalChinesePeriod))]
  EastAsianTraditionalChinesePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1ChtPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianTraditionalChinesePlain))]
  EastAsianTraditionalChinesePlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnChsDbPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianJapaneseDoubleBytePeriod))]
  EastAsianJapaneseDoubleBytePeriod,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnKorPlain ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianJapaneseKoreanPlain))]
  EastAsianJapaneseKoreanPlain,
  /// <summary>
  ///   Autonumbering Enum ( ea1JpnKorPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.EastAsianJapaneseKoreanPeriod))]
  EastAsianJapaneseKoreanPeriod,
  /// <summary>
  ///   Autonumbering Enum ( arabic1Minus ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.Arabic1Minus))]
  Arabic1Minus,
  /// <summary>
  ///   Autonumbering Enum ( arabic2Minus ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.Arabic2Minus))]
  Arabic2Minus,
  /// <summary>
  ///   Autonumbering Enum ( hebrew2Minus ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.Hebrew2Minus))]
  Hebrew2Minus,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ThaiAlphaPeriod))]
  ThaiAlphaPeriod,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ThaiAlphaParenthesisRight))]
  ThaiAlphaParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( thaiAlphaParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ThaiAlphaParenthesisBoth))]
  ThaiAlphaParenthesisBoth,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ThaiNumberPeriod))]
  ThaiNumberPeriod,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ThaiNumberParenthesisRight))]
  ThaiNumberParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( thaiNumParenBoth ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.ThaiNumberParenthesisBoth))]
  ThaiNumberParenthesisBoth,
  /// <summary>
  ///   Autonumbering Enum ( hindiAlphaPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.HindiAlphaPeriod))]
  HindiAlphaPeriod,
  /// <summary>
  ///   Autonumbering Enum ( hindiNumPeriod ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.HindiNumPeriod))]
  HindiNumPeriod,
  /// <summary>
  ///   Autonumbering Enum ( hindiNumParenR ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.HindiNumberParenthesisRight))]
  HindiNumberParenthesisRight,
  /// <summary>
  ///   Autonumbering Enum ( hindiAlpha1Period ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAutoNumberSchemeValues.HindiAlpha1Period))]
  HindiAlpha1Period
}