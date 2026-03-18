namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a stock chart, including series, labels, drop lines, high-low lines, up-down bars, axis identifiers, and extension list.
/// </summary>
public class StockChart : ModelElement<DXDC.StockChart>
{
  /// <summary>
  ///   Series displayed in the stock chart.
  /// </summary>
  public LineChartSeriesList? LineChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Drop lines configuration for the chart.
  /// </summary>
  public DropLines? DropLines { get; set; }

  /// <summary>
  ///   High-low lines configuration for the chart.
  /// </summary>
  public HighLowLines? HighLowLines { get; set; }

  /// <summary>
  ///   Up-down bars configuration for the chart.
  /// </summary>
  public UpDownBars? UpDownBars { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public StockChartExtensionList? StockChartExtensionList { get; set; }
}