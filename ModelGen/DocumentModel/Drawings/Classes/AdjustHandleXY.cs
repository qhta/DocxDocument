namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an XY-based adjust handle for a custom shape. The position of this adjust handle is specified by the corresponding pos child element. The allowed adjustment of this adjust handle are specified via it's min and max type attributes. Based on the adjustment of this adjust handle certain corresponding guides are updated to contain these values.
/// </summary>
public partial class AdjustHandleXY
{
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment x position from this adjust handle.
  /// </summary>
  public String? XAdjustmentGuide { get; set; }
  
  
  /// <summary>
  ///   Specifies the minimum horizontal position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the x direction. That is the maxX and minX are equal.
  /// </summary>
  public String? MinX { get; set; }
  
  
  /// <summary>
  ///   Specifies the maximum horizontal position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the x direction. That is the maxX and minX are equal.
  /// </summary>
  public String? MaxX { get; set; }
  
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment y position from this adjust handle.
  /// </summary>
  public String? YAdjustmentGuide { get; set; }
  
  
  /// <summary>
  ///   Specifies the minimum vertical position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the y direction. That is the maxY and minY are equal.
  /// </summary>
  public String? MinY { get; set; }
  
  
  /// <summary>
  ///   Specifies the maximum vertical position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the y direction. That is the maxY and minY are equal.
  /// </summary>
  public String? MaxY { get; set; }
  
  
  /// <summary>
  ///   Position.
  /// </summary>
  public DocumentModel.Drawings.Position? Position { get; set; }
  
}
