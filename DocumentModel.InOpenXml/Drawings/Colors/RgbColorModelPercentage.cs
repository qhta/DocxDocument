namespace DocumentModel.Drawings;
/// <summary>
/// Represents an RGB color using percentage values with optional color transformations.
/// This is the percentage variant of the RGB color model used in Office Open XML DrawingML, 
/// allowing colors to be specified as percentage values for red, green, and blue components (0-100%)
/// with optional modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
[OpenXmlType(typeof(DXD.RgbColorModelPercentage))]
[XmlRoot("RgbColorModelPercentage", Namespace = "DocumentModel.Drawings")]
public partial class RgbColorModelPercentage : DrawingsColorBase<DXD.RgbColorModelPercentage>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Red component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of red in the color where 0 is no red and 100,000 is maximum red (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no red), 50,000 (50% red), 100,000 (full red).
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.RedPortion))]
  public Percentage R { get => base.Red ?? 0; set => base.Red = value; }

  /// <summary>
  /// Green component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of green in the color where 0 is no green and 100,000 is maximum green (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no green), 50,000 (50% green), 100,000 (full green).
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.GreenPortion))]
  public Percentage G { get => base.Green ?? 0; set => base.Green = value; }

  /// <summary>
  /// Blue component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of blue in the color where 0 is no blue and 100,000 is maximum blue (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no blue), 50,000 (50% blue), 100,000 (full blue).
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.BluePortion))]
  public Percentage B { get => base.Blue ?? 0; set => base.Blue = value; }

}