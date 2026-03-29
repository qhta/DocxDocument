namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a chart gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartgallery?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartGallery
{
  /// <summary>
  /// The built-in gallery.
  /// </summary>
  BuiltIn = 21,
  /// <summary>
  /// The user-defined gallery.
  /// </summary>
  UserDefined = 22,
  /// <summary>
  /// Either of the galleries.
  /// </summary>
  AnyGallery = 23
}
