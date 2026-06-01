
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of the chart item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartitem?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlChartItem
{
  /// <summary>
  /// Data label.
  /// </summary>
  IDataLabel = 0,
  /// <summary>
  /// IChart area.
  /// </summary>
  IChartArea = 2,
  /// <summary>
  /// ISeries lines.
  /// </summary>
  ISeries = 3,
  /// <summary>
  /// IChart title.
  /// </summary>
  IChartTitle = 4,
  /// <summary>
  /// IWalls.
  /// </summary>
  IWalls = 5,
  /// <summary>
  /// ICorners.
  /// </summary>
  ICorners = 6,
  /// <summary>
  /// Data table.
  /// </summary>
  IDataTable = 7,
  /// <summary>
  /// Trend line.
  /// </summary>
  ITrendline = 8,
  /// <summary>
  /// Y error bars.
  /// </summary>
  IErrorBars = 9,
  /// <summary>
  /// X error bars.
  /// </summary>
  XErrorBars = 10,
  /// <summary>
  /// Y error bars.
  /// </summary>
  YErrorBars = 11,
  /// <summary>
  /// ILegend entry.
  /// </summary>
  ILegendEntry = 12,
  /// <summary>
  /// ILegend key.
  /// </summary>
  ILegendKey = 13,
  /// <summary>
  /// IShape.
  /// </summary>
  IShape = 14,
  /// <summary>
  /// Major gridlines.
  /// </summary>
  MajorGridlines = 15,
  /// <summary>
  /// Minor gridlines.
  /// </summary>
  MinorGridlines = 16,
  /// <summary>
  /// IAxis title.
  /// </summary>
  IAxisTitle = 17,
  /// <summary>
  /// Up bars.
  /// </summary>
  IUpBars = 18,
  /// <summary>
  /// Plot area.
  /// </summary>
  IPlotArea = 19,
  /// <summary>
  /// Down bars.
  /// </summary>
  IDownBars = 20,
  /// <summary>
  /// IAxis.
  /// </summary>
  IAxis = 21,
  /// <summary>
  /// ISeries lines.
  /// </summary>
  ISeriesLines = 22,
  /// <summary>
  /// IFloor.
  /// </summary>
  IFloor = 23,
  /// <summary>
  /// ILegend.
  /// </summary>
  ILegend = 24,
  /// <summary>
  /// HiLo lines.
  /// </summary>
  IHiLoLines = 25,
  /// <summary>
  /// Drop lines.
  /// </summary>
  IDropLines = 26,
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
  ILeaderLines = 29,
  /// <summary>
  /// Display unit label.
  /// </summary>
  IDisplayUnitLabel = 30,
  /// <summary>
  /// PivotChart field button.
  /// </summary>
  PivotChartFieldButton = 31,
  /// <summary>
  /// PivotChart drop zone.
  /// </summary>
  PivotChartDropZone = 32
}

