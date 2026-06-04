
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlChartItem")]
public enum ChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabel")]
  DataLabel = 0,
  /// <summary>
  /// Chart area.
  /// </summary>
  [OfficeInteropEnumValue("xlChartArea")]
  ChartArea = 2,
  /// <summary>
  /// Series lines.
  /// </summary>
  [OfficeInteropEnumValue("xlSeries")]
  Series = 3,
  /// <summary>
  /// Chart title.
  /// </summary>
  [OfficeInteropEnumValue("xlChartTitle")]
  ChartTitle = 4,
  /// <summary>
  /// Walls.
  /// </summary>
  [OfficeInteropEnumValue("xlWalls")]
  Walls = 5,
  /// <summary>
  /// Corners.
  /// </summary>
  [OfficeInteropEnumValue("xlCorners")]
  Corners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  [OfficeInteropEnumValue("xlDataTable")]
  DataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  [OfficeInteropEnumValue("xlTrendline")]
  Trendline = 8,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [OfficeInteropEnumValue("xlErrorBars")]
  ErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  [OfficeInteropEnumValue("xlXErrorBars")]
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  [OfficeInteropEnumValue("xlYErrorBars")]
  YErrorBars = 11,
  /// <summary>
  /// Legend entry.
  /// </summary>
  [OfficeInteropEnumValue("xlLegendEntry")]
  LegendEntry = 12,
  /// <summary>
  /// Legend key.
  /// </summary>
  [OfficeInteropEnumValue("xlLegendKey")]
  LegendKey = 13,
  /// <summary>
  /// Shape.
  /// </summary>
  [OfficeInteropEnumValue("xlShape")]
  Shape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  [OfficeInteropEnumValue("xlMajorGridlines")]
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  [OfficeInteropEnumValue("xlMinorGridlines")]
  MinorGridlines = 16,
  /// <summary>
  /// Axis title.
  /// </summary>
  [OfficeInteropEnumValue("xlAxisTitle")]
  AxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  [OfficeInteropEnumValue("xlUpBars")]
  UpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  [OfficeInteropEnumValue("xlPlotArea")]
  PlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  [OfficeInteropEnumValue("xlDownBars")]
  DownBars = 20,
  /// <summary>
  /// Axis.
  /// </summary>
  [OfficeInteropEnumValue("xlAxis")]
  Axis = 21,
  /// <summary>
  /// Series lines.
  /// </summary>
  [OfficeInteropEnumValue("xlSeriesLines")]
  SeriesLines = 22,
  /// <summary>
  /// Floor.
  /// </summary>
  [OfficeInteropEnumValue("xlFloor")]
  Floor = 23,
  /// <summary>
  /// Legend.
  /// </summary>
  [OfficeInteropEnumValue("xlLegend")]
  Legend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  [OfficeInteropEnumValue("xlHiLoLines")]
  HiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  [OfficeInteropEnumValue("xlDropLines")]
  DropLines = 26,
  /// <summary>
  /// Radar axis labels.
  /// </summary>
  [OfficeInteropEnumValue("xlRadarAxisLabels")]
  RadarAxisLabels = 27,
  /// <summary>
  /// Nothing.
  /// </summary>
  [OfficeInteropEnumValue("xlNothing")]
  Nothing = 28,
  /// <summary>
  /// Leader lines.
  /// </summary>
  [OfficeInteropEnumValue("xlLeaderLines")]
  LeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  [OfficeInteropEnumValue("xlDisplayUnitLabel")]
  DisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  [OfficeInteropEnumValue("xlPivotChartFieldButton")]
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  [OfficeInteropEnumValue("xlPivotChartDropZone")]
  PivotChartDropZone = 32
}
