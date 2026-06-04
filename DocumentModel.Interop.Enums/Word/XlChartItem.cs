namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlChartItem))]
public enum ChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlDataLabel))]
  DataLabel = 0,
  /// <summary>
  /// Chart area.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlChartArea))]
  ChartArea = 2,
  /// <summary>
  /// Series.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlSeries))]
  Series = 3,
  /// <summary>
  /// Chart title.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlChartTitle))]
  ChartTitle = 4,
  /// <summary>
  /// Walls.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlWalls))]
  Walls = 5,
  /// <summary>
  /// Corners.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlCorners))]
  Corners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlDataTable))]
  DataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlTrendline))]
  Trendline = 8,
  /// <summary>
  /// Error bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlErrorBars))]
  ErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlXErrorBars))]
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlYErrorBars))]
  YErrorBars = 11,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlLegendEntry))]
  LegendEntry = 12,
  /// <summary>
  /// Legend key. public enum ChartItem
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlLegendKey))]
  LegendKey = 13,
  /// <summary>
  /// Shape.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlShape))]
  Shape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlMajorGridlines))]
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlMinorGridlines))]
  MinorGridlines = 16,
  /// <summary>
  /// Axis title.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlAxisTitle))]
  AxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlUpBars))]
  UpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlPlotArea))]
  PlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlDownBars))]
  DownBars = 20,
  /// <summary>
  /// Axis title.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlAxis))]
  Axis = 21,
  /// <summary>
  /// Series lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlSeriesLines))]
  SeriesLines = 22,
  /// <summary>
  /// Floor.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlFloor))]
  Floor = 23,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlLegend))]
  Legend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlHiLoLines))]
  HiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlDropLines))]
  DropLines = 26,
  /// <summary>
  /// Radar axis labels.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlRadarAxisLabels))]
  RadarAxisLabels = 27,
  /// <summary>
  /// Nothing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlNothing))]
  Nothing = 28,
  /// <summary>
  /// Leader lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlLeaderLines))]
  LeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlDisplayUnitLabel))]
  DisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlPivotChartFieldButton))]
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartItem.xlPivotChartDropZone))]
  PivotChartDropZone = 32
}
