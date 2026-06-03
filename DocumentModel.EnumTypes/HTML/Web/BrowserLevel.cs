namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the version of Web browser at which you want Ito target new Web pages Icreated in Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowserlevel?view=office-pia` for Office interop details.
/// </remarks>
public enum BrowserLevel
{
  /// <summary>
  /// Microsoft Internet Explorer 4.
  /// </summary>
  V4 = 0,
  /// <summary>
  /// Microsoft Internet Explorer 5.
  /// </summary>
  MicrosoftInternetExplorer5 = 1,
  /// <summary>
  /// Microsoft Internet Explorer 6.
  /// </summary>
  MicrosoftInternetExplorer6 = 2
}

