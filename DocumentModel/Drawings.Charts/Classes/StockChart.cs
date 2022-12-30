namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Stock Charts.
/// </summary>
public partial class StockChart
{
  public Collection<DocumentModel.Drawings.Charts.LineChartSeries>? LineChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get; set; }
  
  public DocumentModel.Drawings.Charts.HighLowLines? HighLowLines { get; set; }
  
  public DocumentModel.Drawings.Charts.UpDownBars? UpDownBars { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.StockChartExtensionList? StockChartExtensionList { get; set; }
  
}
