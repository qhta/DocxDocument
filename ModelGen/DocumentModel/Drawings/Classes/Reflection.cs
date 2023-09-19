namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a reflection effect.
/// </summary>
public partial class Reflection
{
  
  /// <summary>
  ///   Specifies the blur radius.
  /// </summary>
  [SchemaAttr("blurRad")]
  public Int64? BlurRadius { get; set; }
  
  
  /// <summary>
  ///   starting reflection opacity.
  /// </summary>
  [SchemaAttr("stA")]
  public Int32? StartOpacity { get; set; }
  
  
  /// <summary>
  ///   Specifies the start position (along the alpha gradient ramp) of the start alpha value.
  /// </summary>
  [SchemaAttr("stPos")]
  public Int32? StartPosition { get; set; }
  
  
  /// <summary>
  ///   Specifies the ending reflection opacity.
  /// </summary>
  [SchemaAttr("endA")]
  public Int32? EndAlpha { get; set; }
  
  
  /// <summary>
  ///   Specifies the end position (along the alpha gradient ramp) of the end alpha value.
  /// </summary>
  [SchemaAttr("endPos")]
  public Int32? EndPosition { get; set; }
  
  
  /// <summary>
  ///   Specifies how far to distance the shadow.
  /// </summary>
  [SchemaAttr("dist")]
  public Int64? Distance { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction of the alpha gradient ramp relative to the shape itself.
  /// </summary>
  [SchemaAttr("dir")]
  public Int32? Direction { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction to offset the reflection.
  /// </summary>
  [SchemaAttr("fadeDir")]
  public Int32? FadeDirection { get; set; }
  
  
  /// <summary>
  ///   Specifies the horizontal scaling factor.
  /// </summary>
  [SchemaAttr("sx")]
  public Int32? HorizontalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the vertical scaling factor.
  /// </summary>
  [SchemaAttr("sy")]
  public Int32? VerticalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle.
  /// </summary>
  [SchemaAttr("kx")]
  public Int32? HorizontalSkew { get; set; }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle.
  /// </summary>
  [SchemaAttr("ky")]
  public Int32? VerticalSkew { get; set; }
  
  
  /// <summary>
  ///   Specifies shadow alignment.
  /// </summary>
  [SchemaAttr("algn")]
  public DocumentModel.Drawings.RectangleAlignmentValues? Alignment { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [SchemaAttr("rotWithShape")]
  public Boolean? RotateWithShape { get; set; }
  
}
