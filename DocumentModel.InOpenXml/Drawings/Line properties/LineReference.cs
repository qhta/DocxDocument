namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a line style, including style matrix index and color information in multiple color models.
/// </summary>
public partial class LineReference : ModelElement
{
  /// <summary>
  ///   Index into the style matrix for the line style.
  /// </summary>
  public int StyleMatrixIndex { get; set; }
  /// <summary>
  ///   Line color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  /// <summary>
  ///   Line color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  ///   Line color specified using the hue, saturation, luminance (HSL) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }
  /// <summary>
  ///   Line color specified using a system-defined color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }
  /// <summary>
  ///   Line color specified using a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
  /// <summary>
  ///   Line color specified using a preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}