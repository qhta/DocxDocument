namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an Outer Shadow Effect.
/// </summary>
public partial class OuterShadow
{
  
  /// <summary>
  ///   Specifies the blur radius of the shadow.
  /// </summary>
  public Int64? BlurRadius { get; set; }
  
  
  /// <summary>
  ///   Specifies the how far to offset the shadow.
  /// </summary>
  public Int64? Distance { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction to offset the shadow.
  /// </summary>
  public Int32? Direction { get; set; }
  
  
  /// <summary>
  ///   Specifies the horizontal scaling factor; negative scaling causes a flip.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the vertical scaling factor; negative scaling causes a flip.
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
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DMD.HslColor? HslColor { get; set; }
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
  public DMD.SystemColor? SystemColor { get; set; }
  
  
  /// <summary>
  ///   Scheme Color.
  /// </summary>
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}
