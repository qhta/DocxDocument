namespace DocumentModel.Drawings;
/// <summary>
///   Represents a foreground color, supporting multiple color models for fill formatting.
/// </summary>
public partial class ForegroundColor : ModelElement<DXD.ForegroundColor>
{
  /// <summary>
  ///   Foreground color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  /// <summary>
  ///   Foreground color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  ///   Foreground color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }
  /// <summary>
  ///   Foreground color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }
  /// <summary>
  ///   Foreground color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
  /// <summary>
  ///   Foreground color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}