namespace DocumentModel.Drawings;


/// <summary>
///   This element represents a reference to a themed font.  When used it specifies which themed font to use along with a choice of color.
/// </summary>
public partial class FontReference
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
  ///   Scheme Color.
  /// </summary>
  public DocumentModel.Drawings.SchemeColorKind? SchemeColor { get; set; }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  public DocumentModel.Drawings.PresetColorKind? PresetColor { get; set; }
  
}
