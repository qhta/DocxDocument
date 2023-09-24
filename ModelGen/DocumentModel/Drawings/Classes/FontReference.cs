namespace DocumentModel.Drawings;


/// <summary>
///   This element represents a reference to a themed font.  When used it specifies which themed font to use along with a choice of color.
/// </summary>
public partial class FontReference
{
  
  /// <summary>
  ///   Specifies the identifier of the font to reference.
  /// </summary>
  public FontCollectionIndexKind? Index { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  public HslColor? HslColor { get; set; }
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
  public SystemColor? SystemColor { get; set; }
  
  
  /// <summary>
  ///   Scheme Color.
  /// </summary>
  public SchemeColorKind? SchemeColor { get; set; }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  public PresetColorKind? PresetColor { get; set; }
  
}
