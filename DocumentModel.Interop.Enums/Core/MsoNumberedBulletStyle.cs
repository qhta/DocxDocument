namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msonumberedbulletstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoNumberedBulletStyle")]
public enum NumberedBulletStyle
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletStyleMixed")]
  StyleMixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletAlphaLCPeriod")]
  AlphaLCPeriod = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletAlphaUCPeriod")]
  AlphaUCPeriod = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicParenRight")]
  ArabicParenRight = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicPeriod")]
  ArabicPeriod = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletRomanLCParenBoth")]
  RomanLCParenBoth = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletRomanLCParenRight")]
  RomanLCParenRight = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletRomanLCPeriod")]
  RomanLCPeriod = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletRomanUCPeriod")]
  RomanUCPeriod = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletAlphaLCParenBoth")]
  AlphaLCParenBoth = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletAlphaLCParenRight")]
  AlphaLCParenRight = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletAlphaUCParenBoth")]
  AlphaUCParenBoth = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletAlphaUCParenRight")]
  AlphaUCParenRight = 11,
  /// <summary>
  /// public enum class NumberedBulletStyle
  /// </summary>
  [InteropEnumValue("msoBulletArabicParenBoth")]
  ArabicParenBoth = 12,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicPlain")]
  ArabicPlain = 13,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletRomanUCParenBoth")]
  RomanUCParenBoth = 14,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletRomanUCParenRight")]
  RomanUCParenRight = 15,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletSimpChinPlain")]
  SimpChinPlain = 16,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletSimpChinPeriod")]
  SimpChinPeriod = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletCircleNumDBPlain")]
  CircleNumDBPlain = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletCircleNumWDWhitePlain")]
  CircleNumWDWhitePlain = 19,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletCircleNumWDBlackPlain")]
  CircleNumWDBlackPlain = 20,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletTradChinPlain")]
  TradChinPlain = 21,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletTradChinPeriod")]
  TradChinPeriod = 22,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicAlphaDash")]
  ArabicAlphaDash = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicAbjadDash")]
  ArabicAbjadDash = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletHebrewAlphaDash")]
  HebrewAlphaDash = 25,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletKanjiKoreanPlain")]
  KanjiKoreanPlain = 26,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletKanjiKoreanPeriod")]
  KanjiKoreanPeriod = 27,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicDBPlain")]
  ArabicDBPlain = 28,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletArabicDBPeriod")]
  ArabicDBPeriod = 29,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletThaiAlphaPeriod")]
  ThaiAlphaPeriod = 30,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletThaiAlphaParenRight")]
  ThaiAlphaParenRight = 31,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletThaiAlphaParenBoth")]
  ThaiAlphaParenBoth = 32,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletThaiNumPeriod")]
  ThaiNumPeriod = 33,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletThaiNumParenRight")]
  ThaiNumParenRight = 34,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletThaiNumParenBoth")]
  ThaiNumParenBoth = 35,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletHindiAlphaPeriod")]
  HindiAlphaPeriod = 36,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletHindiNumPeriod")]
  HindiNumPeriod = 37,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletKanjiSimpChinDBPeriod")]
  KanjiSimpChinDBPeriod = 38,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletHindiNumParenRight")]
  HindiNumParenRight = 39,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletHindiAlpha1Period")]
  HindiAlpha1Period = 40
}
