namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a point in 3D space.  This point is the point in space that anchors the backdrop plane.
/// </summary>
public partial class Anchor
{
  
  /// <summary>
  ///   X-Coordinate in 3D space.
  /// </summary>
  [SchemaAttr("x")]
  public Int64? X { get; set; }
  
  
  /// <summary>
  ///   Y-Coordinate in 3D space.
  /// </summary>
  [SchemaAttr("y")]
  public Int64? Y { get; set; }
  
  
  /// <summary>
  ///   Z-Coordinate in 3D space.
  /// </summary>
  [SchemaAttr("z")]
  public Int64? Z { get; set; }
  
}
