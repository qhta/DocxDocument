namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Outer Shadow Effect.
/// </summary>
public class OuterShadow: ModelElement
{
  /// <summary>
  ///   Blur Radius
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  ///   Shadow Offset Distance
  /// </summary>
  public Int64? Distance { get; set; }

  /// <summary>
  ///   Shadow Direction
  /// </summary>
  public Int32? Direction { get; set; }

  /// <summary>
  ///   Horizontal Scaling Factor
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical Scaling Factor
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Horizontal Skew
  /// </summary>
  public Int32? HorizontalSkew { get; set; }

  /// <summary>
  ///   Vertical Skew
  /// </summary>
  public Int32? VerticalSkew { get; set; }

  /// <summary>
  ///   Shadow Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public bool? RotateWithShape { get; set; }

  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  ///   System Color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  ///   Scheme Color.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  ///   Preset Color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}