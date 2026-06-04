namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlChartItem")]
public enum ChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  [WordInteropEnumValue("xlDataLabel")]
  DataLabel = 0,
  /// <summary>
  /// Chart area.
  /// </summary>
  [WordInteropEnumValue("xlChartArea")]
  ChartArea = 2,
  /// <summary>
  /// Series.
  /// </summary>
  [WordInteropEnumValue("xlSeries")]
  Series = 3,
  /// <summary>
  /// Chart title.
  /// </summary>
  [WordInteropEnumValue("xlChartTitle")]
  ChartTitle = 4,
  /// <summary>
  /// Walls.
  /// </summary>
  [WordInteropEnumValue("xlWalls")]
  Walls = 5,
  /// <summary>
  /// Corners.
  /// </summary>
  [WordInteropEnumValue("xlCorners")]
  Corners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  [WordInteropEnumValue("xlDataTable")]
  DataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  [WordInteropEnumValue("xlTrendline")]
  Trendline = 8,
  /// <summary>
  /// Error bars.
  /// </summary>
  [WordInteropEnumValue("xlErrorBars")]
  ErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  [WordInteropEnumValue("xlXErrorBars")]
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [WordInteropEnumValue("xlYErrorBars")]
  YErrorBars = 11,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [WordInteropEnumValue("xlLegendEntry")]
  LegendEntry = 12,
  /// <summary>
  /// Legend key. public enum ChartItem
  /// </summary>
  [WordInteropEnumValue("xlLegendKey")]
  LegendKey = 13,
  /// <summary>
  /// Shape.
  /// </summary>
  [WordInteropEnumValue("xlShape")]
  Shape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  [WordInteropEnumValue("xlMajorGridlines")]
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  [WordInteropEnumValue("xlMinorGridlines")]
  MinorGridlines = 16,
  /// <summary>
  /// Axis title.
  /// </summary>
  [WordInteropEnumValue("xlAxisTitle")]
  AxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  [WordInteropEnumValue("xlUpBars")]
  UpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  [WordInteropEnumValue("xlPlotArea")]
  PlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  [WordInteropEnumValue("xlDownBars")]
  DownBars = 20,
  /// <summary>
  /// Axis title.
  /// </summary>
  [WordInteropEnumValue("xlAxis")]
  Axis = 21,
  /// <summary>
  /// Series lines.
  /// </summary>
  [WordInteropEnumValue("xlSeriesLines")]
  SeriesLines = 22,
  /// <summary>
  /// Floor.
  /// </summary>
  [WordInteropEnumValue("xlFloor")]
  Floor = 23,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [WordInteropEnumValue("xlLegend")]
  Legend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  [WordInteropEnumValue("xlHiLoLines")]
  HiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  [WordInteropEnumValue("xlDropLines")]
  DropLines = 26,
  /// <summary>
  /// Radar axis labels.
  /// </summary>
  [WordInteropEnumValue("xlRadarAxisLabels")]
  RadarAxisLabels = 27,
  /// <summary>
  /// Nothing.
  /// </summary>
  [WordInteropEnumValue("xlNothing")]
  Nothing = 28,
  /// <summary>
  /// Leader lines.
  /// </summary>
  [WordInteropEnumValue("xlLeaderLines")]
  LeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  [WordInteropEnumValue("xlDisplayUnitLabel")]
  DisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  [WordInteropEnumValue("xlPivotChartFieldButton")]
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  [WordInteropEnumValue("xlPivotChartDropZone")]
  PivotChartDropZone = 32
}
