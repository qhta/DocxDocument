namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the LineChartSeries Class.
/// </summary>
public partial class LineChartSeries
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
  ///   Marker.
  /// </summary>
  public DMDC.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public DMDC.PictureOptions? PictureOptions { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.ErrorBars? ErrorBars { get; set; }
  
  public DMDC.CategoryAxisData? CategoryAxisData { get; set; }
  
  public DMDC.Values? Values { get; set; }
  
  public DMDC.Smooth? Smooth { get; set; }
  
  public DMDC.LineSerExtensionList? LineSerExtensionList { get; set; }
  
}
