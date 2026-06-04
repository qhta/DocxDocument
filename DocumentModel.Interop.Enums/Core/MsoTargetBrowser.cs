namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies target browser for documents viewed in a Web browser.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotargetbrowser?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTargetBrowser")]
public enum TargetBrowser
{
  /// <summary>
  /// Netscape Navigator 3.
  /// </summary>
  [OfficeInteropEnumValue("msoTargetBrowserV3")]
  V3,
  /// <summary>
  /// Netscape Navigator 4.
  /// </summary>
  [OfficeInteropEnumValue("msoTargetBrowserV4")]
  V4,
  /// <summary>
  /// Microsoft Internet Explorer 4.0.
  /// </summary>
  [OfficeInteropEnumValue("msoTargetBrowserIE4")]
  IE4,
  /// <summary>
  /// Microsoft Internet Explorer 5.
  /// </summary>
  [OfficeInteropEnumValue("msoTargetBrowserIE5")]
  IE5,
  /// <summary>
  /// Microsoft Internet Explorer 6.
  /// </summary>
  [OfficeInteropEnumValue("msoTargetBrowserIE6")]
  IE6
}
