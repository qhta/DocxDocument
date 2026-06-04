namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdlanguageid2000?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLanguageID2000")]
public enum LanguageID2000
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdChineseHongKong")]
  ChineseHongKong = 3076,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdChineseMacao")]
  ChineseMacao = 5124,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdEnglishTrinidad")]
  EnglishTrinidad = 11273
}
