
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartitem?view=office-pia` for Office interop details.
/// </remarks>
public enum ChartItem
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
  /// Series lines.
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
  /// Y error bars.
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
  /// Legend key.
  /// </summary>
  LegendKey = 13,
  /// <summary>
  /// Shape.
  /// </summary>
  Shape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  MinorGridlines = 16,
  /// <summary>
  /// Axis title.
  /// </summary>
  AxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  UpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  PlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  DownBars = 20,
  /// <summary>
  /// Axis.
  /// </summary>
  Axis = 21,
  /// <summary>
  /// Series lines.
  /// </summary>
  SeriesLines = 22,
  /// <summary>
  /// Floor.
  /// </summary>
  Floor = 23,
  /// <summary>
  /// Legend.
  /// </summary>
  Legend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  HiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  DropLines = 26,
  /// <summary>
  /// Radar axis labels.
  /// </summary>
  RadarAxisLabels = 27,
  /// <summary>
  /// Nothing.
  /// </summary>
  Nothing = 28,
  /// <summary>
  /// Leader lines.
  /// </summary>
  LeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  DisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  PivotChartDropZone = 32
}
