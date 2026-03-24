namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  DataLabel = 0,
  /// <summary>
  /// Chart area.
  /// </summary>
  ChartArea = 2,
  /// <summary>
  /// Series.
  /// </summary>
  Series = 3,
  /// <summary>
  /// Chart title.
  /// </summary>
  ChartTitle = 4,
  /// <summary>
  /// Walls.
  /// </summary>
  Walls = 5,
  /// <summary>
  /// Corners.
  /// </summary>
  Corners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  DataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  Trendline = 8,
  /// <summary>
  /// Error bars.
  /// </summary>
  ErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  YErrorBars = 11,
  /// <summary>
  /// Legend entry.
  /// </summary>
  LegendEntry = 12,
  /// <summary>
  /// Legend key. public enum XlChartItem
  /// </summary>
  LegendKey = 13,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  Shape = 14,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  MajorGridlines = 15,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  MinorGridlines = 16,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  AxisTitle = 17,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  UpBars = 18,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  PlotArea = 19,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  DownBars = 20,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  Axis = 21,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  SeriesLines = 22,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  Floor = 23,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  Legend = 24,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  HiLoLines = 25,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  DropLines = 26,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  RadarAxisLabels = 27,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  Nothing = 28,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  LeaderLines = 29,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  DisplayUnitLabel = 30,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  PivotChartFieldButton = 31,
  /// <summary>
  /// Specifies the type of the chart item.
  /// </summary>
  PivotChartDropZone = 32
}
