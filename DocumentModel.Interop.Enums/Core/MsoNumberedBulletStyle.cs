namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msonumberedbulletstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoNumberedBulletStyle))]
public enum NumberedBulletStyle
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletStyleMixed))]
  StyleMixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletAlphaLCPeriod))]
  AlphaLCPeriod = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletAlphaUCPeriod))]
  AlphaUCPeriod = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicParenRight))]
  ArabicParenRight = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicPeriod))]
  ArabicPeriod = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletRomanLCParenBoth))]
  RomanLCParenBoth = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletRomanLCParenRight))]
  RomanLCParenRight = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletRomanLCPeriod))]
  RomanLCPeriod = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletRomanUCPeriod))]
  RomanUCPeriod = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletAlphaLCParenBoth))]
  AlphaLCParenBoth = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletAlphaLCParenRight))]
  AlphaLCParenRight = 9,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletAlphaUCParenBoth))]
  AlphaUCParenBoth = 10,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletAlphaUCParenRight))]
  AlphaUCParenRight = 11,
  /// <summary>
  /// public enum class NumberedBulletStyle
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicParenBoth))]
  ArabicParenBoth = 12,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicPlain))]
  ArabicPlain = 13,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletRomanUCParenBoth))]
  RomanUCParenBoth = 14,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletRomanUCParenRight))]
  RomanUCParenRight = 15,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletSimpChinPlain))]
  SimpChinPlain = 16,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletSimpChinPeriod))]
  SimpChinPeriod = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletCircleNumDBPlain))]
  CircleNumDBPlain = 18,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletCircleNumWDWhitePlain))]
  CircleNumWDWhitePlain = 19,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletCircleNumWDBlackPlain))]
  CircleNumWDBlackPlain = 20,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletTradChinPlain))]
  TradChinPlain = 21,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletTradChinPeriod))]
  TradChinPeriod = 22,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicAlphaDash))]
  ArabicAlphaDash = 23,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicAbjadDash))]
  ArabicAbjadDash = 24,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletHebrewAlphaDash))]
  HebrewAlphaDash = 25,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletKanjiKoreanPlain))]
  KanjiKoreanPlain = 26,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletKanjiKoreanPeriod))]
  KanjiKoreanPeriod = 27,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicDBPlain))]
  ArabicDBPlain = 28,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletArabicDBPeriod))]
  ArabicDBPeriod = 29,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletThaiAlphaPeriod))]
  ThaiAlphaPeriod = 30,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletThaiAlphaParenRight))]
  ThaiAlphaParenRight = 31,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletThaiAlphaParenBoth))]
  ThaiAlphaParenBoth = 32,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletThaiNumPeriod))]
  ThaiNumPeriod = 33,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletThaiNumParenRight))]
  ThaiNumParenRight = 34,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletThaiNumParenBoth))]
  ThaiNumParenBoth = 35,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletHindiAlphaPeriod))]
  HindiAlphaPeriod = 36,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletHindiNumPeriod))]
  HindiNumPeriod = 37,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletKanjiSimpChinDBPeriod))]
  KanjiSimpChinDBPeriod = 38,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletHindiNumParenRight))]
  HindiNumParenRight = 39,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoNumberedBulletStyle.msoBulletHindiAlpha1Period))]
  HindiAlpha1Period = 40
}
