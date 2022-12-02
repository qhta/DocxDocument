namespace DocumentModel.Drawing;

/// <summary>
/// Preset Shadow.
/// </summary>
public interface IPresetShadow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Shadow
  /// </summary>
  public PresetShadowKind? Preset { get ; set; }
  
  /// <summary>
  /// Distance
  /// </summary>
  public Int64? Distance { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public Int32? Direction { get ; set; }
  
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
