namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the PieChartSeries Class.
/// </summary>
public partial class PieChartSeries
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
  ///   Explosion.
  /// </summary>
  public DMDC.Explosion? Explosion { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.CategoryAxisData? CategoryAxisData { get; set; }
  
  public DMDC.Values? Values { get; set; }
  
  public DMDC.PieSerExtensionList? PieSerExtensionList { get; set; }
  
}
