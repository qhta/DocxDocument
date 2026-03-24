
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how
/// pictures are displayed on a column, bar picture chart, or legend key.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartpicturetype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartPictureType
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how
  /// pictures are displayed on a column, bar picture chart, or legend key.
  /// </summary>
  ackScale = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Picture is sized to
  /// repeat a maximum
  /// </summary>
  ack = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Picture is stretched
  /// the full length of stacked bar.
  /// </summary>
  retch = 1
}
