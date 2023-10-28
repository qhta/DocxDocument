namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pivot Format.
/// </summary>
public partial class PivotFormat
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DMDC.Index? Index { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDC.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  public DMDC.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   Data Label.
  /// </summary>
  public DMDC.DataLabel? DataLabel { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
