namespace DocumentModel.Drawings;
/// <summary>
///   Represents an inner shadow effect, including blur, offset, direction, and color options.
/// </summary>
public partial class InnerShadow : ModelElement
{
  /// <summary>
  ///   Blur radius of the inner shadow.
  /// </summary>
  public Int64? BlurRadius { get; set; }
  /// <summary>
  ///   Distance to offset the inner shadow from the object.
  /// </summary>
  public Int64? Distance { get; set; }
  /// <summary>
  ///   Direction angle of the inner shadow.
  /// </summary>
  public Int32? Direction { get; set; }
  /// <summary>
  ///   Inner shadow color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  /// <summary>
  ///   Inner shadow color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  ///   Inner shadow color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }
  /// <summary>
  ///   Inner shadow color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }
  /// <summary>
  ///   Inner shadow color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
  /// <summary>
  ///   Inner shadow color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}