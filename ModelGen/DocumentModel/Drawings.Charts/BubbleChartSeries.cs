namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleChartSeries Class.
/// </summary>
public partial class BubbleChartSeries
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DMDC.Index? Index { get; set; }
  
  
  /// <summary>
  ///   Order.
  /// </summary>
  public DMDC.Order? Order { get; set; }
  
  
  /// <summary>
  ///   Series Text.
  /// </summary>
  public DMDC.SeriesText? SeriesText { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public DMDC.PictureOptions? PictureOptions { get; set; }
  
  
  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  public DMDC.InvertIfNegative? InvertIfNegative { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.XValues? XValues { get; set; }
  
  public DMDC.YValues? YValues { get; set; }
  
  public DMDC.BubbleSize? BubbleSize { get; set; }
  
  public DMDC.Bubble3D? Bubble3D { get; set; }
  
  public DMDC.BubbleSerExtensionList? BubbleSerExtensionList { get; set; }
  
}
