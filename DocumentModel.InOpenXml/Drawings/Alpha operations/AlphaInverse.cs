namespace DocumentModel.Drawings;

/// <summary>
/// Represents an alpha inverse effect, which inverts the alpha channel of an image or shape and supports various color models.
/// </summary>
public interface AlphaInverse
{
  /// <summary>
  /// RGB color model using percentage values for the alpha inverse effect.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  /// RGB color model using hexadecimal values for the alpha inverse effect.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  /// HSL (Hue, Saturation, Luminance) color model for the alpha inverse effect.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  /// System color for the alpha inverse effect.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  /// Scheme color for the alpha inverse effect.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  /// Preset color for the alpha inverse effect.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}