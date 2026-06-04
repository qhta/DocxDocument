namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the axis type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxistype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlAxisType")]
public enum AxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  [InteropEnumValue("xlCategory")]
  Category = 1,
  /// <summary>
  /// Axis displays values.
  /// </summary>
  [InteropEnumValue("xlValue")]
  Value = 2,
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  [InteropEnumValue("xlSeriesAxis")]
  SeriesAxis = 3
}
