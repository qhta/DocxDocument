namespace DocumentModel.Drawings;

/// <summary>
///   Represents the color used for the contour of a 3D object, supporting multiple color models.
/// </summary>
public class ContourColor: ModelElement<DXD.ContourColor>
{
  /// <summary>
  ///   Color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  ///   Color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   Color specified using the Hue, Saturation, Luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  ///   Color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  ///   Color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  ///   Color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}