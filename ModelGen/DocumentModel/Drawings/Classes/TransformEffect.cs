namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a transform effect. The transform is applied to each point in the shape's geometry using the following matrix:
/// </summary>
public partial class TransformEffect
{
  
  /// <summary>
  ///   Specifies a percentage by which to horizontally scale the object.
  /// </summary>
  [SchemaAttr("sx")]
  public Int32? HorizontalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies a percentage by which to vertically scale the object.
  /// </summary>
  [SchemaAttr("sy")]
  public Int32? VerticalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle, defined as the angle between the top-left corner and bottom-left corner of the object's original bounding box. If positive, the bottom edge of the shape is positioned to the right relative to the top edge.
  /// </summary>
  [SchemaAttr("kx")]
  public Int32? HorizontalSkew { get; set; }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle, defined as the angle between the top-left corner and top-right corner of the object's original bounding box. If positive, the right edge of the object is positioned lower relative to the left edge.
  /// </summary>
  [SchemaAttr("ky")]
  public Int32? VerticalSkew { get; set; }
  
  
  /// <summary>
  ///   Specifies an amount by which to shift the object along the x-axis.
  /// </summary>
  [SchemaAttr("tx")]
  public Int64? HorizontalShift { get; set; }
  
  
  /// <summary>
  ///   Specifies an amount by which to shift the object along the y-axis.
  /// </summary>
  [SchemaAttr("ty")]
  public Int64? VerticalShift { get; set; }
  
}
