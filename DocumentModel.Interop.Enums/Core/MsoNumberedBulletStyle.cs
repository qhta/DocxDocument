namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msonumberedbulletstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoNumberedBulletStyle")]
public enum NumberedBulletStyle
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletStyleMixed")]
  StyleMixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletAlphaLCPeriod")]
  AlphaLCPeriod = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletAlphaUCPeriod")]
  AlphaUCPeriod = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicParenRight")]
  ArabicParenRight = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicPeriod")]
  ArabicPeriod = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletRomanLCParenBoth")]
  RomanLCParenBoth = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletRomanLCParenRight")]
  RomanLCParenRight = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletRomanLCPeriod")]
  RomanLCPeriod = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletRomanUCPeriod")]
  RomanUCPeriod = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletAlphaLCParenBoth")]
  AlphaLCParenBoth = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletAlphaLCParenRight")]
  AlphaLCParenRight = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletAlphaUCParenBoth")]
  AlphaUCParenBoth = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletAlphaUCParenRight")]
  AlphaUCParenRight = 11,
  /// <summary>
  /// public enum class NumberedBulletStyle
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicParenBoth")]
  ArabicParenBoth = 12,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicPlain")]
  ArabicPlain = 13,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletRomanUCParenBoth")]
  RomanUCParenBoth = 14,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletRomanUCParenRight")]
  RomanUCParenRight = 15,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletSimpChinPlain")]
  SimpChinPlain = 16,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletSimpChinPeriod")]
  SimpChinPeriod = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletCircleNumDBPlain")]
  CircleNumDBPlain = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletCircleNumWDWhitePlain")]
  CircleNumWDWhitePlain = 19,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletCircleNumWDBlackPlain")]
  CircleNumWDBlackPlain = 20,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletTradChinPlain")]
  TradChinPlain = 21,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletTradChinPeriod")]
  TradChinPeriod = 22,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicAlphaDash")]
  ArabicAlphaDash = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicAbjadDash")]
  ArabicAbjadDash = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletHebrewAlphaDash")]
  HebrewAlphaDash = 25,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletKanjiKoreanPlain")]
  KanjiKoreanPlain = 26,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletKanjiKoreanPeriod")]
  KanjiKoreanPeriod = 27,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicDBPlain")]
  ArabicDBPlain = 28,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletArabicDBPeriod")]
  ArabicDBPeriod = 29,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletThaiAlphaPeriod")]
  ThaiAlphaPeriod = 30,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletThaiAlphaParenRight")]
  ThaiAlphaParenRight = 31,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletThaiAlphaParenBoth")]
  ThaiAlphaParenBoth = 32,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletThaiNumPeriod")]
  ThaiNumPeriod = 33,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletThaiNumParenRight")]
  ThaiNumParenRight = 34,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletThaiNumParenBoth")]
  ThaiNumParenBoth = 35,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletHindiAlphaPeriod")]
  HindiAlphaPeriod = 36,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletHindiNumPeriod")]
  HindiNumPeriod = 37,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletKanjiSimpChinDBPeriod")]
  KanjiSimpChinDBPeriod = 38,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletHindiNumParenRight")]
  HindiNumParenRight = 39,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletHindiAlpha1Period")]
  HindiAlpha1Period = 40
}
