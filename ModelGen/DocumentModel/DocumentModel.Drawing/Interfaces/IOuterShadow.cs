namespace DocumentModel.Drawing;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelPercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelHex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISystemColor))]
public interface IOuterShadow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public long? BlurRadius { get ; set; }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  public long? Distance { get ; set; }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  public int? Direction { get ; set; }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  public int? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  public int? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public int? HorizontalSkew { get ; set; }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public int? VerticalSkew { get ; set; }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public DocumentModel.Drawing.RectangleAlignmentValues? Alignment { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public bool? RotateWithShape { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
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
  public ISystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public IPresetColor? PresetColor { get ; set; }
  
}
