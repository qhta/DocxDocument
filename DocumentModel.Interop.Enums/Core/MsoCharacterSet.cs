namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the character set to be used when rendering text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocharacterset?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoCharacterSet")]
public enum CharacterSet
{
  /// <summary>
  /// Arabic character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetArabic")]
  Arabic = 1,
  /// <summary>
  /// Cyrillic character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetCyrillic")]
  Cyrillic,
  /// <summary>
  /// English, Western European, and other Latin script character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetEnglishWesternEuropeanOtherLatinScript")]
  EnglishWesternEuropeanOtherLatinScript,
  /// <summary>
  /// Greek character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetGreek")]
  Greek,
  /// <summary>
  /// Hebrew character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetHebrew")]
  Hebrew,
  /// <summary>
  /// Japanese character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetJapanese")]
  Japanese,
  /// <summary>
  /// Korean character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetKorean")]
  Korean,
  /// <summary>
  /// Multilingual Unicode character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetMultilingualUnicode")]
  MultilingualUnicode,
  /// <summary>
  /// Simplified Chinese character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetSimplifiedChinese")]
  SimplifiedChinese,
  /// <summary>
  /// Thai character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetThai")]
  Thai,
  /// <summary>
  /// Traditional Chinese character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetTraditionalChinese")]
  TraditionalChinese,
  /// <summary>
  /// Vietnamese character set.
  /// </summary>
  [OfficeInteropEnumValue("msoCharacterSetVietnamese")]
  Vietnamese
}
