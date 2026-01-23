using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents a specified color for bullets, supporting multiple color models and extension options.
/// </summary>
public class BulletColor: ModelElement<DXD.BulletColor>, IExtendableElement
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
  /// HSL (Hue, Saturation, Luminance) color model.
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

  /// <summary>
  /// List of extensions for the bullet color.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}