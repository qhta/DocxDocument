namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Marker.
/// </summary>
public partial class Marker
{
  
  /// <summary>
  ///   Symbol.
  /// </summary>
  public DMDC.MarkerStyleKind? Symbol { get; set; }
  
  
  /// <summary>
  ///   Size.
  /// </summary>
  public Byte? Size { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
