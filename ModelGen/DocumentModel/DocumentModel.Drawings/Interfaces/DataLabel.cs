namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface DataLabel // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public Layout? Layout { get ; set; }
  
  public ChartText? ChartText { get ; set; }
  
  public NumberingFormat? NumberingFormat { get ; set; }
  
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public TextProperties? TextProperties { get ; set; }
  
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
