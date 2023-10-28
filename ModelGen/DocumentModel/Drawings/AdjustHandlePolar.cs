namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a polar adjust handle for a custom shape. The position of this adjust handle is specified by the corresponding pos child element. The allowed adjustment of this adjust handle are specified via it's min and max attributes. Based on the adjustment of this adjust handle certain corresponding guides are updated to contain these values.
/// </summary>
public partial class AdjustHandlePolar
{
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment radius from this adjust handle.
  /// </summary>
  public String? RadialAdjustmentGuide { get; set; }
  
  
  /// <summary>
  ///   Specifies the minimum radial position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move radially. That is the maxR and minR are equal.
  /// </summary>
  public String? MinRadial { get; set; }
  
  
  /// <summary>
  ///   Specifies the maximum radial position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move radially. That is the maxR and minR are equal.
  /// </summary>
  public String? MaxRadial { get; set; }
  
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment angle from this adjust handle.
  /// </summary>
  public String? AngleAdjustmentGuide { get; set; }
  
  
  /// <summary>
  ///   Specifies the minimum angle position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move angularly. That is the maxAng and minAng are equal.
  /// </summary>
  public String? MinAngle { get; set; }
  
  
  /// <summary>
  ///   Specifies the maximum angle position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move angularly. That is the maxAng and minAng are equal.
  /// </summary>
  public String? MaxAngle { get; set; }
  
  
  /// <summary>
  ///   Shape Position Coordinate.
  /// </summary>
  public DMD.Position? Position { get; set; }
  
}
