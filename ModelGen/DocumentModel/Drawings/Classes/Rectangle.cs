namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the rectangular bounding box for text within a custGeom shape. The default for this rectangle is the bounding box for the shape. This can be modified using this elements four attributes to inset or extend the text bounding box.
/// </summary>
public partial class Rectangle
{
  
  /// <summary>
  ///   Specifies the x coordinate of the left edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  public String? Left { get; set; }
  
  
  /// <summary>
  ///   Specifies the y coordinate of the top edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  public String? Top { get; set; }
  
  
  /// <summary>
  ///   Specifies the x coordinate of the right edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  public String? Right { get; set; }
  
  
  /// <summary>
  ///   Specifies the y coordinate of the bottom edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  public String? Bottom { get; set; }
  
}
