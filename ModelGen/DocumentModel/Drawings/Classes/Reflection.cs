namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a reflection effect.
/// </summary>
public partial class Reflection
{
  
  /// <summary>
  ///   Specifies the blur radius.
  /// </summary>
  public Int64? BlurRadius { get; set; }
  
  
  /// <summary>
  ///   starting reflection opacity.
  /// </summary>
  public Int32? StartOpacity { get; set; }
  
  
  /// <summary>
  ///   Specifies the start position (along the alpha gradient ramp) of the start alpha value.
  /// </summary>
  public Int32? StartPosition { get; set; }
  
  
  /// <summary>
  ///   Specifies the ending reflection opacity.
  /// </summary>
  public Int32? EndAlpha { get; set; }
  
  
  /// <summary>
  ///   Specifies the end position (along the alpha gradient ramp) of the end alpha value.
  /// </summary>
  public Int32? EndPosition { get; set; }
  
  
  /// <summary>
  ///   Specifies how far to distance the shadow.
  /// </summary>
  public Int64? Distance { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction of the alpha gradient ramp relative to the shape itself.
  /// </summary>
  public Int32? Direction { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction to offset the reflection.
  /// </summary>
  public Int32? FadeDirection { get; set; }
  
  
  /// <summary>
  ///   Specifies the horizontal scaling factor.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the vertical scaling factor.
  /// </summary>
  public Int32? VerticalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle.
  /// </summary>
  public Int32? HorizontalSkew { get; set; }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle.
  /// </summary>
  public Int32? VerticalSkew { get; set; }
  
  
  /// <summary>
  ///   Specifies shadow alignment.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
}
