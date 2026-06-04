namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the character set to be used when rendering text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocharacterset?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoCharacterSet))]
public enum CharacterSet
{
  /// <summary>
  /// Arabic character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetArabic))]
  Arabic = 1,
  /// <summary>
  /// Cyrillic character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetCyrillic))]
  Cyrillic,
  /// <summary>
  /// English, Western European, and other Latin script character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetEnglishWesternEuropeanOtherLatinScript))]
  EnglishWesternEuropeanOtherLatinScript,
  /// <summary>
  /// Greek character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetGreek))]
  Greek,
  /// <summary>
  /// Hebrew character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetHebrew))]
  Hebrew,
  /// <summary>
  /// Japanese character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetJapanese))]
  Japanese,
  /// <summary>
  /// Korean character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetKorean))]
  Korean,
  /// <summary>
  /// Multilingual Unicode character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetMultilingualUnicode))]
  MultilingualUnicode,
  /// <summary>
  /// Simplified Chinese character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetSimplifiedChinese))]
  SimplifiedChinese,
  /// <summary>
  /// Thai character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetThai))]
  Thai,
  /// <summary>
  /// Traditional Chinese character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetTraditionalChinese))]
  TraditionalChinese,
  /// <summary>
  /// Vietnamese character set.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCharacterSet.msoCharacterSetVietnamese))]
  Vietnamese
}
