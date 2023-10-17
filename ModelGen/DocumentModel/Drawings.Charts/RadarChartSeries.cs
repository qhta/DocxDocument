namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the RadarChartSeries Class.
/// </summary>
public partial class RadarChartSeries
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
  ///   Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.CategoryAxisData? CategoryAxisData { get; set; }
  
  public DocumentModel.Drawings.Charts.Values? Values { get; set; }
  
  public DocumentModel.Drawings.Charts.RadarSerExtensionList? RadarSerExtensionList { get; set; }
  
  public DM.ElementCollection<DataPoint>? Items { get; set; }
  
}
