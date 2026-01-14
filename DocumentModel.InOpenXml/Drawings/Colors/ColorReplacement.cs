namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color replacement effect for drawing elements.
/// </summary>
public interface ColorReplacement: IExtendableElement
{
  /// <summary>
  /// RGB color model - percentage variant.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

  /// <summary>
  /// RGB color model - hex variant.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  /// Hue, saturation, luminance color model.
  /// </summary>
  public HslColor? HslColor { get; set; }

  /// <summary>
  /// System color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }

  /// <summary>
  /// Scheme color.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }

  /// <summary>
  /// Preset color.
  /// </summary>
  public PresetColor? PresetColor { get; set; }
}