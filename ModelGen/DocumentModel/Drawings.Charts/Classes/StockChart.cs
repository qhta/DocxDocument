namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Stock Charts.
/// </summary>
public partial class StockChart
{
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get; set; }
  
  public DocumentModel.Drawings.Charts.HighLowLines? HighLowLines { get; set; }
  
  public DocumentModel.Drawings.Charts.UpDownBars? UpDownBars { get; set; }
  
  public DocumentModel.Drawings.Charts.StockChartExtensionList? StockChartExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
