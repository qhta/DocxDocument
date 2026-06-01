namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Stock Charts.
/// </summary>
public class StockChart: ModelElement
{
  public Collection<LineChartSeries>? LineChartSeries { get; set; }

  public IDataLabels? IDataLabels { get; set; }

  public IDropLines? IDropLines { get; set; }

  public HighLowLines? HighLowLines { get; set; }

  public UpDownBars? UpDownBars { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public StockChartExtensionList? StockChartExtensionList { get; set; }
}
