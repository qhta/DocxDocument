namespace DocumentModel.Drawings;

/// <summary>
/// Glow Effect.
/// </summary>
public partial class Glow
{
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius { get; set; }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawings.SchemeColor? SchemeColor { get; set; }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public DocumentModel.Drawings.PresetColor? PresetColor { get; set; }
  
}
