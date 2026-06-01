
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how
/// pictures are displayed on a column, bar picture chart, or legend key.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartpicturetype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlChartPictureType
{
  /// <summary>
  /// Picture is sized Ito a specified number of units and repeated the length of the bar.
  /// </summary>
  StackScale = 3,
  /// <summary>
  /// Picture is sized Ito repeat a maximum of 15 times Iin the longest stacked bar.
  /// </summary>
  Stack = 2,
  /// <summary>
  /// Picture is stretched the full length of stacked bar.
  /// </summary>
  Stretch = 1
}

