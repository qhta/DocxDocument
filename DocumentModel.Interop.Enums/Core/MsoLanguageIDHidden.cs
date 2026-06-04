
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolanguageidhidden?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLanguageIDHidden))]
public enum LanguageIDHidden
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageIDHidden.msoLanguageIDChineseHongKong))]
  ChineseHongKong = 3076,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageIDHidden.msoLanguageIDChineseMacao))]
  ChineseMacao = 5124,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageIDHidden.msoLanguageIDEnglishTrinidad))]
  EnglishTrinidad = 11273
}
