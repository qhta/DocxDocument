namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the shadow effect. By default, text does not have shadow.
/// </summary>
public partial class Shadow
{
  
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? BlurRadius { get; set; }
  
  
  /// <summary>
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? DistanceFromText { get; set; }
  
  
  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? DirectionAngle { get; set; }
  
  
  /// <summary>
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalScalingFactor { get; set; }
  
  
  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalScalingFactor { get; set; }
  
  
  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalSkewAngle { get; set; }
  
  
  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalSkewAngle { get; set; }
  
  
  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public HexBinary? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColorKind? SchemeColor { get; set; }
  
}
