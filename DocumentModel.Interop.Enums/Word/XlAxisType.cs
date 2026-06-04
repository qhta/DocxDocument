namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the axis type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxistype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlAxisType")]
public enum AxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  [WordInteropEnumValue("xlCategory")]
  Category = 1,
  /// <summary>
  /// Axis displays values.
  /// </summary>
  [WordInteropEnumValue("xlValue")]
  Value = 2,
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  [WordInteropEnumValue("xlSeriesAxis")]
  SeriesAxis = 3
}
