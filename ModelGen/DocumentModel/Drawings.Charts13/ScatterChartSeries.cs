namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public partial class ScatterChartSeries
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
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.XValues? XValues { get; set; }
  
  public DMDC.YValues? YValues { get; set; }
  
  public DMDC.Smooth? Smooth { get; set; }
  
  public DMDC.ScatterSerExtensionList? ScatterSerExtensionList { get; set; }
  
}
