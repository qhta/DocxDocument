
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlChartItem))]
public enum ChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlDataLabel))]
  DataLabel = 0,
  /// <summary>
  /// Chart area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlChartArea))]
  ChartArea = 2,
  /// <summary>
  /// Series lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlSeries))]
  Series = 3,
  /// <summary>
  /// Chart title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlChartTitle))]
  ChartTitle = 4,
  /// <summary>
  /// Walls.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlWalls))]
  Walls = 5,
  /// <summary>
  /// Corners.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlCorners))]
  Corners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlDataTable))]
  DataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlTrendline))]
  Trendline = 8,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlErrorBars))]
  ErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlXErrorBars))]
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlYErrorBars))]
  YErrorBars = 11,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlLegendEntry))]
  LegendEntry = 12,
  /// <summary>
  /// Legend key.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlLegendKey))]
  LegendKey = 13,
  /// <summary>
  /// Shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlShape))]
  Shape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlMajorGridlines))]
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlMinorGridlines))]
  MinorGridlines = 16,
  /// <summary>
  /// Axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlAxisTitle))]
  AxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlUpBars))]
  UpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlPlotArea))]
  PlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlDownBars))]
  DownBars = 20,
  /// <summary>
  /// Axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlAxis))]
  Axis = 21,
  /// <summary>
  /// Series lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlSeriesLines))]
  SeriesLines = 22,
  /// <summary>
  /// Floor.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlFloor))]
  Floor = 23,
  /// <summary>
  /// Legend.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlLegend))]
  Legend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlHiLoLines))]
  HiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlDropLines))]
  DropLines = 26,
  /// <summary>
  /// Radar axis labels.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlRadarAxisLabels))]
  RadarAxisLabels = 27,
  /// <summary>
  /// Nothing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlNothing))]
  Nothing = 28,
  /// <summary>
  /// Leader lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlLeaderLines))]
  LeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlDisplayUnitLabel))]
  DisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlPivotChartFieldButton))]
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartItem.xlPivotChartDropZone))]
  PivotChartDropZone = 32
}
