namespace DocumentModel.Drawings;

/// <summary>
///   Represents a duotone effect, allowing colorization using two colors specified in various color models.
/// </summary>
public class Duotone: ModelElement<DXD.Duotone>
{
  /// <summary>
  ///   Duotone color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  ///   Duotone color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   Duotone color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  ///   Duotone color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  ///   Duotone color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  ///   Duotone color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}