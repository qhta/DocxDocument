namespace DocumentModel.Drawings;

/// <summary>
/// Represents the background color, supporting multiple color models and types for flexible color specification.
/// </summary>
public class BackgroundColor: ModelElement
{
  /// <summary>
  /// Gets or sets the RGB color model using percentage values for the background color.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  /// Gets or sets the RGB color model using hexadecimal values for the background color.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  /// Gets or sets the HSL (Hue, Saturation, Lightness) color model for the background color.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  /// Gets or sets the system color for the background color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  /// Gets or sets the scheme color for the background color.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  /// Gets or sets the preset color for the background color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}