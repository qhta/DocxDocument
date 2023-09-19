namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the reflection effect.
/// </summary>
public partial class Reflection
{
  
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:blurRad")]
  public Int64? BlurRadius { get; set; }
  
  
  /// <summary>
  ///   stA, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:stA")]
  public Int32? StartingOpacity { get; set; }
  
  
  /// <summary>
  ///   stPos, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:stPos")]
  public Int32? StartPosition { get; set; }
  
  
  /// <summary>
  ///   endA, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:endA")]
  public Int32? EndingOpacity { get; set; }
  
  
  /// <summary>
  ///   endPos, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:endPos")]
  public Int32? EndPosition { get; set; }
  
  
  /// <summary>
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:dist")]
  public Int64? DistanceFromText { get; set; }
  
  
  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:dir")]
  public Int32? DirectionAngle { get; set; }
  
  
  /// <summary>
  ///   fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:fadeDir")]
  public Int32? FadeDirection { get; set; }
  
  
  /// <summary>
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:sx")]
  public Int32? HorizontalScalingFactor { get; set; }
  
  
  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:sy")]
  public Int32? VerticalScalingFactor { get; set; }
  
  
  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:kx")]
  public Int32? HorizontalSkewAngle { get; set; }
  
  
  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:ky")]
  public Int32? VerticalSkewAngle { get; set; }
  
  
  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:algn")]
  public DocumentModel.Wordprocessing.RectangleAlignmentValues? Alignment { get; set; }
  
}
