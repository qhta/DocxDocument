namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the language to use to determine which line break level is used when the line break control option
/// is turned on.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofareastlinebreaklanguageid?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFarEastLineBreakLanguageID))]
public enum FarEastLineBreakLanguageID
{
  /// <summary>
  /// Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFarEastLineBreakLanguageID.MsoFarEastLineBreakLanguageJapanese))]
  Japanese = 1041,
  /// <summary>
  /// Korean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFarEastLineBreakLanguageID.MsoFarEastLineBreakLanguageKorean))]
  Korean = 1042,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFarEastLineBreakLanguageID.MsoFarEastLineBreakLanguageSimplifiedChinese))]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFarEastLineBreakLanguageID.MsoFarEastLineBreakLanguageTraditionalChinese))]
  TraditionalChinese = 1028
}
