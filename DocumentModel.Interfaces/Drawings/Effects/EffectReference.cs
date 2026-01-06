namespace DocumentModel.Drawings;

/// <summary>
/// Represents a reference to various color models and color types used in drawing effects.
/// </summary>
public interface EffectReference
{
  /// <summary>
  /// Gets or sets the RGB color model using percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  /// Gets or sets the RGB color model using hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  /// Gets or sets the HSL (Hue, Saturation, Lightness) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  /// Gets or sets the system color, which refers to a color defined by the system.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  /// Gets or sets the scheme color, which refers to a color defined by a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  /// Gets or sets the preset color, which refers to a predefined color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}