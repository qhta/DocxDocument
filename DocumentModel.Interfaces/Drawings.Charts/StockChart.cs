namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Stock Charts.
/// </summary>
public interface StockChart
{
  public LineChartSeries LineChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public DropLines? DropLines { get; set; }
  public HighLowLines? HighLowLines { get; set; }
  public UpDownBars? UpDownBars { get; set; }
  public AxisIds AxisIds { get; set; }
  public StockChartExtensionList? StockChartExtensionList { get; set; }
}