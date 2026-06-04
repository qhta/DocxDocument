namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pictures are displayed on a column, bar picture chart, or legend key.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartpicturetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlChartPictureType")]
public enum ChartPictureType
{
  /// <summary>
  /// Picture is stretched the full length of the stacked bar.
  /// </summary>
  [WordInteropEnumValue("xlStretch")]
  retch = 1,
  /// <summary>
  /// Picture is sized to repeat a maximum of 15 times in the longest stacked bar.
  /// </summary>
  [WordInteropEnumValue("xlStack")]
  ack = 2,
  /// <summary>
  /// Picture is sized to a specified number of units and repeated the length of the bar.
  /// </summary>
  [WordInteropEnumValue("xlStackScale")]
  ackScale = 3
}
