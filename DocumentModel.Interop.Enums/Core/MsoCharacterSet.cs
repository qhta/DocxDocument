namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the character set to be used when rendering text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocharacterset?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoCharacterSet")]
public enum CharacterSet
{
  /// <summary>
  /// Arabic character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetArabic")]
  Arabic = 1,
  /// <summary>
  /// Cyrillic character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetCyrillic")]
  Cyrillic,
  /// <summary>
  /// English, Western European, and other Latin script character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetEnglishWesternEuropeanOtherLatinScript")]
  EnglishWesternEuropeanOtherLatinScript,
  /// <summary>
  /// Greek character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetGreek")]
  Greek,
  /// <summary>
  /// Hebrew character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetHebrew")]
  Hebrew,
  /// <summary>
  /// Japanese character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetJapanese")]
  Japanese,
  /// <summary>
  /// Korean character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetKorean")]
  Korean,
  /// <summary>
  /// Multilingual Unicode character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetMultilingualUnicode")]
  MultilingualUnicode,
  /// <summary>
  /// Simplified Chinese character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetSimplifiedChinese")]
  SimplifiedChinese,
  /// <summary>
  /// Thai character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetThai")]
  Thai,
  /// <summary>
  /// Traditional Chinese character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetTraditionalChinese")]
  TraditionalChinese,
  /// <summary>
  /// Vietnamese character set.
  /// </summary>
  [InteropEnumValue("msoCharacterSetVietnamese")]
  Vietnamese
}
