namespace DocumentModel.Interop.Word;

/// <summary>
/// Series-name-level constants passed to and returned by the SeriesNameLevel property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlseriesnamelevel?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlSeriesNameLevel")]
public enum SeriesNameLevel
{
  /// <summary>
  /// Sets no series names in the chart.
  /// </summary>
  [WordInteropEnumValue("xlSeriesNameLevelNone")]
  None = -3,
  /// <summary>
  /// Indicates literal data in the series names.
  /// </summary>
  [WordInteropEnumValue("xlSeriesNameLevelCustom")]
  Custom = -2,
  /// <summary>
  /// Sets series names to all series name levels within range on the chart. The default.
  /// </summary>
  [WordInteropEnumValue("xlSeriesNameLevelAll")]
  All = -1
}
