namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies target browser for documents viewed in a Web browser.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotargetbrowser?view=office-pia` for Office interop details.
/// </remarks>
public enum TargetBrowser
{
  /// <summary>
  /// Netscape Navigator 3.
  /// </summary>
  V3,
  /// <summary>
  /// Netscape Navigator 4.
  /// </summary>
  V4,
  /// <summary>
  /// Microsoft Internet Explorer 4.0.
  /// </summary>
  IE4,
  /// <summary>
  /// Microsoft Internet Explorer 5.
  /// </summary>
  IE5,
  /// <summary>
  /// Microsoft Internet Explorer 6.
  /// </summary>
  IE6
}
