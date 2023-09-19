namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Color2Type Class.
/// </summary>
public partial class Color2Type
{
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}
