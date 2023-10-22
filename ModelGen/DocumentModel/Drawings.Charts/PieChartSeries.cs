namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie Chart Series.
/// </summary>
public partial class PieChartSeries
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
  ///   Explosion.
  /// </summary>
  public DocumentModel.Drawings.Charts.Explosion? Explosion { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.CategoryAxisData? CategoryAxisData { get; set; }
  
  public DocumentModel.Drawings.Charts.Values? Values { get; set; }
  
  public DocumentModel.Drawings.Charts.PieSerExtensionList? PieSerExtensionList { get; set; }
  
}
