namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Labels.
/// </summary>
public partial class DataLabels
{
  public DMDC.Delete? Delete { get; set; }
  
  public DMDC.NumberingFormat? NumberingFormat { get; set; }
  
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  public DMDC.TextProperties? TextProperties { get; set; }
  
  public DMDC.DataLabelPositionKind? DataLabelPosition { get; set; }
  
  public DMDC.ShowLegendKey? ShowLegendKey { get; set; }
  
  public DMDC.ShowValue? ShowValue { get; set; }
  
  public DMDC.ShowCategoryName? ShowCategoryName { get; set; }
  
  public DMDC.ShowSeriesName? ShowSeriesName { get; set; }
  
  public DMDC.ShowPercent? ShowPercent { get; set; }
  
  public DMDC.ShowBubbleSize? ShowBubbleSize { get; set; }
  
  public DMDC.Separator? Separator { get; set; }
  
  public DMDC.ShowLeaderLines? ShowLeaderLines { get; set; }
  
  public DMDC.LeaderLines? LeaderLines { get; set; }
  
  public DMDC.DLblsExtensionList? DLblsExtensionList { get; set; }
  
}
