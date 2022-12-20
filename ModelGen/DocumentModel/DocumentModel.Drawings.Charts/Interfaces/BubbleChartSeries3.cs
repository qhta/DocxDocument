namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public partial interface BubbleChartSeries3
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order { get; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText { get; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  public Boolean? InvertIfNegative { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.DataPoint>? DataPoints { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.Trendline>? Trendlines { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.ErrorBars>? ErrorBarses { get; set; }
  
  public DocumentModel.Drawings.Charts.XValues? XValues { get; set; }
  
  public DocumentModel.Drawings.Charts.YValues? YValues { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleSize? BubbleSize { get; set; }
  
  public Boolean? Bubble3D { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleSerExtensionList? BubbleSerExtensionList { get; set; }
  
}
