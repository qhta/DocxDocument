
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlChartItem")]
public enum ChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  [InteropEnumValue("xlDataLabel")]
  DataLabel = 0,
  /// <summary>
  /// Chart area.
  /// </summary>
  [InteropEnumValue("xlChartArea")]
  ChartArea = 2,
  /// <summary>
  /// Series lines.
  /// </summary>
  [InteropEnumValue("xlSeries")]
  Series = 3,
  /// <summary>
  /// Chart title.
  /// </summary>
  [InteropEnumValue("xlChartTitle")]
  ChartTitle = 4,
  /// <summary>
  /// Walls.
  /// </summary>
  [InteropEnumValue("xlWalls")]
  Walls = 5,
  /// <summary>
  /// Corners.
  /// </summary>
  [InteropEnumValue("xlCorners")]
  Corners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  [InteropEnumValue("xlDataTable")]
  DataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  [InteropEnumValue("xlTrendline")]
  Trendline = 8,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [InteropEnumValue("xlErrorBars")]
  ErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  [InteropEnumValue("xlXErrorBars")]
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [InteropEnumValue("xlYErrorBars")]
  YErrorBars = 11,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [InteropEnumValue("xlLegendEntry")]
  LegendEntry = 12,
  /// <summary>
  /// Legend key.
  /// </summary>
  [InteropEnumValue("xlLegendKey")]
  LegendKey = 13,
  /// <summary>
  /// Shape.
  /// </summary>
  [InteropEnumValue("xlShape")]
  Shape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  [InteropEnumValue("xlMajorGridlines")]
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  [InteropEnumValue("xlMinorGridlines")]
  MinorGridlines = 16,
  /// <summary>
  /// Axis title.
  /// </summary>
  [InteropEnumValue("xlAxisTitle")]
  AxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  [InteropEnumValue("xlUpBars")]
  UpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  [InteropEnumValue("xlPlotArea")]
  PlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  [InteropEnumValue("xlDownBars")]
  DownBars = 20,
  /// <summary>
  /// Axis.
  /// </summary>
  [InteropEnumValue("xlAxis")]
  Axis = 21,
  /// <summary>
  /// Series lines.
  /// </summary>
  [InteropEnumValue("xlSeriesLines")]
  SeriesLines = 22,
  /// <summary>
  /// Floor.
  /// </summary>
  [InteropEnumValue("xlFloor")]
  Floor = 23,
  /// <summary>
  /// Legend.
  /// </summary>
  [InteropEnumValue("xlLegend")]
  Legend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  [InteropEnumValue("xlHiLoLines")]
  HiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  [InteropEnumValue("xlDropLines")]
  DropLines = 26,
  /// <summary>
  /// Radar axis labels.
  /// </summary>
  [InteropEnumValue("xlRadarAxisLabels")]
  RadarAxisLabels = 27,
  /// <summary>
  /// Nothing.
  /// </summary>
  [InteropEnumValue("xlNothing")]
  Nothing = 28,
  /// <summary>
  /// Leader lines.
  /// </summary>
  [InteropEnumValue("xlLeaderLines")]
  LeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  [InteropEnumValue("xlDisplayUnitLabel")]
  DisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  [InteropEnumValue("xlPivotChartFieldButton")]
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  [InteropEnumValue("xlPivotChartDropZone")]
  PivotChartDropZone = 32
}
