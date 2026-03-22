namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the version of Web browser at which you want to target new Web pages created in Microsoft Word.
/// </summary>
public enum WdBrowserLevel
{
  /// <summary>
  /// Microsoft Internet Explorer 4.
  /// </summary>
  wdBrowserLevelV4 = unchecked((int)0),
  /// <summary>
  /// Microsoft Internet Explorer 5.
  /// </summary>
  wdBrowserLevelMicrosoftInternetExplorer5 = unchecked((int)1),
  /// <summary>
  /// Microsoft Internet Explorer 6.
  /// </summary>
  wdBrowserLevelMicrosoftInternetExplorer6 = unchecked((int)2)
}
