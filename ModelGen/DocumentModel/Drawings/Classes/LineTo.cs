namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the drawing of a straight line from the current pen position to the new point specified. This line becomes part of the shape geometry, representing a side of the shape. The coordinate system used when specifying this line is the path coordinate system.
/// </summary>
public partial class LineTo
{
  
  /// <summary>
  ///   Line end point.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Drawings.AdjustPoint2DType? Point { get; set; }
  
}
