namespace DocumentModel.Drawings;

/// <summary>
/// Stock Charts.
/// </summary>
public interface StockChart
{
  public Collection<LineChartSeries1>? LineChartSerieses { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public HighLowLines? HighLowLines { get ; set; }
  
  public UpDownBars? UpDownBars { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public StockChartExtensionList? StockChartExtensionList { get ; set; }
  
}
