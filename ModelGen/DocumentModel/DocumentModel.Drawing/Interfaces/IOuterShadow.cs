namespace DocumentModel.Drawing;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
public interface IOuterShadow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public System.Int64? BlurRadius { get ; set; }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  public System.Int64? Distance { get ; set; }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  public System.Int32? Direction { get ; set; }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  public System.Int32? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  public System.Int32? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public System.Int32? HorizontalSkew { get ; set; }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public System.Int32? VerticalSkew { get ; set; }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public DocumentModel.Drawing.RectangleAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public System.Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawing.SchemeColorKind? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public DocumentModel.Drawing.PresetColorKind? PresetColor { get ; set; }
  
}
