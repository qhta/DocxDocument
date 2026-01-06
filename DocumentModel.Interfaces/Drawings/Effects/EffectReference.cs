namespace DocumentModel.Drawings;

/// <summary>
/// Represents a reference to various color models and color types used in drawing effects.
/// </summary>
public interface EffectReference
{
  /// <summary>
  /// RGB color model using percentage values.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  /// RGB color model using hexadecimal values.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  /// HSL (Hue, Saturation, Lightness) color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  /// System color, which refers to a color defined by the system.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  /// Scheme color, which refers to a color defined by a color scheme.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  /// Preset color, which refers to a predefined color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}