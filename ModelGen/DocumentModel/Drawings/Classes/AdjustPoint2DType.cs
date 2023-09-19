namespace DocumentModel.Drawings;


/// <summary>
///   Defines the AdjustPoint2DType Class.
/// </summary>
public partial class AdjustPoint2DType
{
  
  /// <summary>
  ///   X-Coordinate
  /// </summary>
  [SchemaAttr("x")]
  public String? X { get; set; }
  
  
  /// <summary>
  ///   Y-Coordinate
  /// </summary>
  [SchemaAttr("y")]
  public String? Y { get; set; }
  
}
