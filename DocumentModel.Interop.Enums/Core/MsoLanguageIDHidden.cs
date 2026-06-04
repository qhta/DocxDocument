
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolanguageidhidden?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLanguageIDHidden")]
public enum LanguageIDHidden
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoLanguageIDChineseHongKong")]
  ChineseHongKong = 3076,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoLanguageIDChineseMacao")]
  ChineseMacao = 5124,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishTrinidad")]
  EnglishTrinidad = 11273
}
