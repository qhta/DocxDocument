namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the version of Web browser at which you want to target new Web pages created in Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowserlevel?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBrowserLevel))]
public enum BrowserLevel
{
  /// <summary>
  /// Microsoft Internet Explorer 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowserLevel.wdBrowserLevelV4))]
  V4 = 0,
  /// <summary>
  /// Microsoft Internet Explorer 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowserLevel.wdBrowserLevelMicrosoftInternetExplorer5))]
  MicrosoftInternetExplorer5 = 1,
  /// <summary>
  /// Microsoft Internet Explorer 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowserLevel.wdBrowserLevelMicrosoftInternetExplorer6))]
  MicrosoftInternetExplorer6 = 2
}
