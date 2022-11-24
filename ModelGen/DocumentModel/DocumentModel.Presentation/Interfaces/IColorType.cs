namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface IColorType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public IHslColor? HslColor { get ; set; }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public ISystemColor? SystemColor { get ; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public ISchemeColor? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public IPresetColor? PresetColor { get ; set; }
  
}
