namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public partial class ScatterChartSeries
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
  ///   Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.XValues? XValues { get; set; }
  
  public DocumentModel.Drawings.Charts.YValues? YValues { get; set; }
  
  public DocumentModel.Drawings.Charts.Smooth? Smooth { get; set; }
  
  public DocumentModel.Drawings.Charts.ScatterSerExtensionList? ScatterSerExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
