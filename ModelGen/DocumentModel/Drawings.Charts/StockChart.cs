namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Stock Charts.
/// </summary>
public partial class StockChart
{
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.DropLines? DropLines { get; set; }
  
  public DMDC.HighLowLines? HighLowLines { get; set; }
  
  public DMDC.UpDownBars? UpDownBars { get; set; }
  
  public DMDC.StockChartExtensionList? StockChartExtensionList { get; set; }
  
}
