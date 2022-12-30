namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Data Labels.
/// </summary>
public partial class DataLabels
{
  public Collection<DocumentModel.Drawings.Charts.DataLabel>? Items { get; set; }
  
  public Boolean? Delete { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelPositionKind? DataLabelPosition { get; set; }
  
  public Boolean? ShowLegendKey { get; set; }
  
  public Boolean? ShowValue { get; set; }
  
  public Boolean? ShowCategoryName { get; set; }
  
  public Boolean? ShowSeriesName { get; set; }
  
  public Boolean? ShowPercent { get; set; }
  
  public Boolean? ShowBubbleSize { get; set; }
  
  public String? Separator { get; set; }
  
  public Boolean? ShowLeaderLines { get; set; }
  
  public DocumentModel.Drawings.Charts.LeaderLines? LeaderLines { get; set; }
  
  public DocumentModel.Drawings.Charts.DLblsExtensionList? DLblsExtensionList { get; set; }
  
}
