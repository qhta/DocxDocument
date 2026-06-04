namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the ideal screen resolution to be used to view a document in a Web browser.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscreensize?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoScreenSize")]
public enum ScreenSize
{
  /// <summary>
  /// 544x376 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize544x376")]
  Size544x376,
  /// <summary>
  /// 640x480 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize640x480")]
  Size640x480,
  /// <summary>
  /// 720x512 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize720x512")]
  Size720x512,
  /// <summary>
  /// 800x600 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize800x600")]
  Size800x600,
  /// <summary>
  /// 1024x768 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1024x768")]
  Size1024x768,
  /// <summary>
  /// 1152x882 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1152x882")]
  Size1152x882,
  /// <summary>
  /// 1152x900 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1152x900")]
  Size1152x900,
  /// <summary>
  /// 1280x1024 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1280x1024")]
  Size1280x1024,
  /// <summary>
  /// 1600x1200 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1600x1200")]
  Size1600x1200,
  /// <summary>
  /// 1800x1440 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1800x1440")]
  Size1800x1440,
  /// <summary>
  /// 1920x1200 resolution.
  /// </summary>
  [OfficeInteropEnumValue("msoScreenSize1920x1200")]
  Size1920x1200
}
