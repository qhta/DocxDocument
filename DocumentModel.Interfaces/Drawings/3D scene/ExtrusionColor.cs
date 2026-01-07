namespace DocumentModel.Drawings;

/// <summary>
///   Represents the color used for the extrusion of a 3D object, supporting multiple color models.
/// </summary>
public interface ExtrusionColor
{
  /// <summary>
  ///   Extrusion color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  ///   Extrusion color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   Extrusion color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  ///   Extrusion color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  ///   Extrusion color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  ///   Extrusion color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}