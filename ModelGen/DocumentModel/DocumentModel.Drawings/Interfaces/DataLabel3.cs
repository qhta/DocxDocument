namespace DocumentModel.Drawings;

/// <summary>
/// Data Label.
/// </summary>
public interface DataLabel3
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public Layout2? Layout { get ; set; }
  
  public ChartText1? ChartText { get ; set; }
  
  public NumberingFormat1? NumberingFormat { get ; set; }
  
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public TextProperties2? TextProperties { get ; set; }
  
  public DataLabelPositionKind? DataLabelPosition { get ; set; }
  
  public Boolean? ShowLegendKey { get ; set; }
  
  public Boolean? ShowValue { get ; set; }
  
  public Boolean? ShowCategoryName { get ; set; }
  
  public Boolean? ShowSeriesName { get ; set; }
  
  public Boolean? ShowPercent { get ; set; }
  
  public Boolean? ShowBubbleSize { get ; set; }
  
  public String? Separator { get ; set; }
  
  public DLblExtensionList? DLblExtensionList { get ; set; }
  
}
