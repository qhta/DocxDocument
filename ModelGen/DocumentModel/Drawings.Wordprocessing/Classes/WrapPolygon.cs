namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public partial class WrapPolygon
{
  
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  public Boolean? Edited { get; set; }
  
  
  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  public Point2DType? StartPoint { get; set; }
  
  public ElementCollection<Point2DType>? Items { get; set; }
  
}
