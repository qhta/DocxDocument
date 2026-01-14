namespace DocumentModel.Drawings;

/// <summary>
///   Represents an outer shadow effect, including blur, offset, direction, scaling, skew, alignment, rotation, and color options.
/// </summary>
public class OuterShadow: ModelElement
{
  /// <summary>
  ///   Blur radius of the shadow.
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  ///   Distance to offset the shadow from the object.
  /// </summary>
  public Int64? Distance { get; set; }

  /// <summary>
  ///   Direction angle of the shadow.
  /// </summary>
  public Int32? Direction { get; set; }

  /// <summary>
  ///   Horizontal scaling factor for the shadow.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical scaling factor for the shadow.
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Horizontal skew of the shadow.
  /// </summary>
  public Int32? HorizontalSkew { get; set; }

  /// <summary>
  ///   Vertical skew of the shadow.
  /// </summary>
  public Int32? VerticalSkew { get; set; }

  /// <summary>
  ///   Alignment of the shadow relative to the object.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Indicates whether the shadow rotates with the shape.
  /// </summary>
  public bool? RotateWithShape { get; set; }

  /// <summary>
  ///   Shadow color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  ///   Shadow color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   Shadow color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  ///   Shadow color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  ///   Shadow color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  ///   Shadow color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}