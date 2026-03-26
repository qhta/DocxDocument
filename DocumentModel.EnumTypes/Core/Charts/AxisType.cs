
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the axis
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxistype?view=office-pia` for Office interop details.
/// </remarks>
public enum AxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  Category = 1,
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  SeriesAxis = 3,
  /// <summary>
  /// Axis displays values.
  /// </summary>
  Value = 2
}
