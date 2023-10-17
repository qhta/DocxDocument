namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Label.
/// </summary>
public partial class DataLabel
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DocumentModel.Drawings.Charts.Index? Index { get; set; }
  
  public DocumentModel.Drawings.Charts.Delete? Delete { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartText? ChartText { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelPositionKind? DataLabelPosition { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowLegendKey? ShowLegendKey { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowValue? ShowValue { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowCategoryName? ShowCategoryName { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowSeriesName? ShowSeriesName { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowPercent? ShowPercent { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowBubbleSize? ShowBubbleSize { get; set; }
  
  public DocumentModel.Drawings.Charts.Separator? Separator { get; set; }
  
  public DocumentModel.Drawings.Charts.DLblExtensionList? DLblExtensionList { get; set; }
  
}
