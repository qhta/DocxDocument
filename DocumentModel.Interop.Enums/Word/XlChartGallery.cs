namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a chart gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartgallery?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlChartGallery")]
public enum XlChartGallery
{
  /// <summary>
  /// The built-in gallery.
  /// </summary>
  [InteropEnumValue("xlBuiltIn")]
  BuiltIn = 21,
  /// <summary>
  /// The user-defined gallery.
  /// </summary>
  [InteropEnumValue("xlUserDefined")]
  UserDefined = 22,
  /// <summary>
  /// Either of the galleries.
  /// </summary>
  [InteropEnumValue("xlAnyGallery")]
  AnyGallery = 23
}
