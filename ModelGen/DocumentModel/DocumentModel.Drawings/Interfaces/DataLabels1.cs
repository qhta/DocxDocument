namespace DocumentModel.Drawings;

/// <summary>
/// Data Labels.
/// </summary>
public interface DataLabels1
{
  public Collection<DataLabel1>? Items { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public NumberingFormat2? NumberingFormat { get ; set; }
  
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public TextProperties1? TextProperties { get ; set; }
  
  public DataLabelPositionKind? DataLabelPosition { get ; set; }
  
  public Boolean? ShowLegendKey { get ; set; }
  
  public Boolean? ShowValue { get ; set; }
  
  public Boolean? ShowCategoryName { get ; set; }
  
  public Boolean? ShowSeriesName { get ; set; }
  
  public Boolean? ShowPercent { get ; set; }
  
  public Boolean? ShowBubbleSize { get ; set; }
  
  public String? Separator { get ; set; }
  
  public Boolean? ShowLeaderLines { get ; set; }
  
  public LeaderLines1? LeaderLines { get ; set; }
  
  public DLblsExtensionList? DLblsExtensionList { get ; set; }
  
}
