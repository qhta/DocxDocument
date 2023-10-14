namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleChartSeries Class.
/// </summary>
public partial class BubbleChartSeries
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DocumentModel.Drawings.Charts.Index? Index { get; set; }
  
  
  /// <summary>
  ///   Order.
  /// </summary>
  public DocumentModel.Drawings.Charts.Order? Order { get; set; }
  
  
  /// <summary>
  ///   Series Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  
  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  public DocumentModel.Drawings.Charts.InvertIfNegative? InvertIfNegative { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.XValues? XValues { get; set; }
  
  public DocumentModel.Drawings.Charts.YValues? YValues { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleSize? BubbleSize { get; set; }
  
  public DocumentModel.Drawings.Charts.Bubble3D? Bubble3D { get; set; }
  
  public DocumentModel.Drawings.Charts.BubbleSerExtensionList? BubbleSerExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
