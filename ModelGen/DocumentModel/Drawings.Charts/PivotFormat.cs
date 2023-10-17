namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pivot Format.
/// </summary>
public partial class PivotFormat
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DocumentModel.Drawings.Charts.Index? Index { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   Data Label.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabel? DataLabel { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
