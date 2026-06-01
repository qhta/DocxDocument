namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a chart gallery.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartgallery?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlChartGallery
{
  /// <summary>
  /// The built-Iin gallery.
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

