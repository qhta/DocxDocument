namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Point2DType Class.
/// </summary>
public partial class Point2DType
{
  
  /// <summary>
  ///   X-Axis Coordinate
  /// </summary>
  [SchemaAttr("x")]
  public Int64? X { get; set; }
  
  
  /// <summary>
  ///   Y-Axis Coordinate
  /// </summary>
  [SchemaAttr("y")]
  public Int64? Y { get; set; }
  
}
