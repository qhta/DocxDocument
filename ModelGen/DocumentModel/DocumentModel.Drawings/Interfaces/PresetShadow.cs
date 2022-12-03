namespace DocumentModel.Drawings;

/// <summary>
/// Preset Shadow.
/// </summary>
public interface PresetShadow // : DocumentModel.BaseTypes.ModelElement
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
  /// Scheme Color.
  /// </summary>
  public SchemeColor? SchemeColor { get ; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public PresetColor? PresetColor { get ; set; }
  
}
