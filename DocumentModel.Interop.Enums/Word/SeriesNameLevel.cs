namespace DocumentModel.Interop.Word;

/// <summary>
/// Series-name-level constants passed to and returned by the SeriesNameLevel property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlseriesnamelevel?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlSeriesNameLevel")]
public enum SeriesNameLevel
{
  /// <summary>
  /// Sets no series names in the chart.
  /// </summary>
  [InteropEnumValue("xlSeriesNameLevelNone")]
  None = -3,
  /// <summary>
  /// Indicates literal data in the series names.
  /// </summary>
  [InteropEnumValue("xlSeriesNameLevelCustom")]
  Custom = -2,
  /// <summary>
  /// Sets series names to all series name levels within range on the chart. The default.
  /// </summary>
  [InteropEnumValue("xlSeriesNameLevelAll")]
  All = -1
}

