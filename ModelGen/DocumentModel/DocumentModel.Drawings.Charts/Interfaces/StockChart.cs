namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Stock Charts.
/// </summary>
public interface StockChart
{
  public DocumentModel.Drawings.Charts.LineChartSeries? LineChartSeries { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get ; set; }
  
  public DocumentModel.Drawings.Charts.HighLowLines? HighLowLines { get ; set; }
  
  public DocumentModel.Drawings.Charts.UpDownBars? UpDownBars { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public DocumentModel.Drawings.Charts.StockChartExtensionList? StockChartExtensionList { get ; set; }
  
}
