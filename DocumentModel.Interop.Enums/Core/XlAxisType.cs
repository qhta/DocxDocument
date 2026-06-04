
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the axis
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxistype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlAxisType")]
public enum AxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  [OfficeInteropEnumValue("xlCategory")]
  Category = 1,
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  [OfficeInteropEnumValue("xlSeriesAxis")]
  SeriesAxis = 3,
  /// <summary>
  /// Axis displays values.
  /// </summary>
  [OfficeInteropEnumValue("xlValue")]
  Value = 2
}
