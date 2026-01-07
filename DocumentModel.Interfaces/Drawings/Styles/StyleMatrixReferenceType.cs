namespace DocumentModel.Drawings;

/// <summary>
///   Represents a reference to a style matrix entry, including index and color information in multiple color models.
/// </summary>
public interface StyleMatrixReferenceType
{
  /// <summary>
  ///   Index into the style matrix.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Color specified using the RGB color model with percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  ///   Color specified using the RGB color model with hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  ///   Color specified using the hue, saturation, luminance (HSL) color model.
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