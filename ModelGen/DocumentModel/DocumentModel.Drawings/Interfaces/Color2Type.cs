namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Color2Type Class.
/// </summary>
public interface Color2Type
{
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public HslColor? HslColor { get ; set; }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public SystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public PresetColor? PresetColor { get ; set; }
  
}
