namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the AreaChartSeries Class.
/// </summary>
public partial class AreaChartSeries
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
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.CategoryAxisData? CategoryAxisData { get; set; }
  
  public DMDC.Values? Values { get; set; }
  
  public DMDC.AreaSerExtensionList? AreaSerExtensionList { get; set; }
  
}
