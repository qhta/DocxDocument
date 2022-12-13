namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface DataLabel
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public DocumentModel.Drawings.Charts.Layout? Layout { get ; set; }
  
  public DocumentModel.Drawings.Charts.ChartText? ChartText { get ; set; }
  
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat { get ; set; }
  
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelPositionKind? DataLabelPosition { get ; set; }
  
  public Boolean? ShowLegendKey { get ; set; }
  
  public Boolean? ShowValue { get ; set; }
  
  public Boolean? ShowCategoryName { get ; set; }
  
  public Boolean? ShowSeriesName { get ; set; }
  
  public Boolean? ShowPercent { get ; set; }
  
  public Boolean? ShowBubbleSize { get ; set; }
  
  public String? Separator { get ; set; }
  
  public DocumentModel.Drawings.Charts.DLblExtensionList? DLblExtensionList { get ; set; }
  
}
