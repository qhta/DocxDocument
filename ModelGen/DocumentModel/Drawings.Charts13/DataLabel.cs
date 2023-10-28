namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public partial class DataLabel
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DMDC.Index? Index { get; set; }
  
  public DMDC.Delete? Delete { get; set; }
  
  public DMDC.Layout? Layout { get; set; }
  
  public DMDC.ChartText? ChartText { get; set; }
  
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
  
  public DMDC.DLblExtensionList? DLblExtensionList { get; set; }
  
}
