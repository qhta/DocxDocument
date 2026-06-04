namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the version of Web browser at which you want to target new Web pages created in Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowserlevel?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBrowserLevel")]
public enum BrowserLevel
{
  /// <summary>
  /// Microsoft Internet Explorer 4.
  /// </summary>
  [InteropEnumValue("wdBrowserLevelV4")]
  V4 = 0,
  /// <summary>
  /// Microsoft Internet Explorer 5.
  /// </summary>
  [InteropEnumValue("wdBrowserLevelMicrosoftInternetExplorer5")]
  MicrosoftInternetExplorer5 = 1,
  /// <summary>
  /// Microsoft Internet Explorer 6.
  /// </summary>
  [InteropEnumValue("wdBrowserLevelMicrosoftInternetExplorer6")]
  MicrosoftInternetExplorer6 = 2
}
