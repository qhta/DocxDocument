namespace DocumentModel.Drawings;

/// <summary>
/// Stock Charts.
/// </summary>
public interface StockChart
{
  public LineChartSeries? LineChartSeries { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public HighLowLines? HighLowLines { get ; set; }
  
  public UpDownBars? UpDownBars { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public StockChartExtensionList? StockChartExtensionList { get ; set; }
  
}
