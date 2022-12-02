namespace DocumentModel.Drawing;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
public interface IOuterShadow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public Int64? BlurRadius { get ; set; }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  public Int64? Distance { get ; set; }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  public Int32? Direction { get ; set; }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  public Int32? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  public Int32? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public Int32? HorizontalSkew { get ; set; }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public Int32? VerticalSkew { get ; set; }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public IHslColor? HslColor { get ; set; }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public ISystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public ISchemeColor? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public IPresetColor? PresetColor { get ; set; }
  
}
