namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a chart gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartgallery?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlChartGallery")]
public enum XlChartGallery
{
  /// <summary>
  /// The built-in gallery.
  /// </summary>
  [WordInteropEnumValue("xlBuiltIn")]
  BuiltIn = 21,
  /// <summary>
  /// The user-defined gallery.
  /// </summary>
  [WordInteropEnumValue("xlUserDefined")]
  UserDefined = 22,
  /// <summary>
  /// Either of the galleries.
  /// </summary>
  [WordInteropEnumValue("xlAnyGallery")]
  AnyGallery = 23
}
