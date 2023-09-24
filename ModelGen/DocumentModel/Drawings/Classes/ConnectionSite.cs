namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of a connection site on a custom shape. A connection site allows a cxnSp to be attached to this shape. This connection is maintained when the shape is repositioned within the document. It should be noted that this connection is placed within the shape bounding box using the transform coordinate system which is also called the shape coordinate system, as it encompasses the entire shape. The width and height for this coordinate system are specified within the ext transform element.
/// </summary>
public partial class ConnectionSite
{
  
  /// <summary>
  ///   Specifies the incoming connector angle. This angle is the angle around the connection site that an incoming connector tries to be routed to. This allows connectors to know where the shape is in relation to the connection site and route connectors so as to avoid any overlap with the shape.
  /// </summary>
  public String? Angle { get; set; }
  
  
  /// <summary>
  ///   Position.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
  
}
