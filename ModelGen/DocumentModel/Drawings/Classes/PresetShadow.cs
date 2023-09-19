namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a preset shadow is to be used. Each preset shadow is equivalent to a specific outer shadow effect.  For each preset shadow, the color element, direction attribute, and distance attribute represent the color, direction, and distance parameters of the corresponding outer shadow. Additionally, the rotateWithShape attribute of corresponding outer shadow is always false.  Other non-default parameters of the outer shadow are dependent on the prst attribute.
/// </summary>
public partial class PresetShadow
{
  
  /// <summary>
  ///   Specifies which preset shadow to use.
  /// </summary>
  [SchemaAttr("prst")]
  public DocumentModel.Drawings.PresetShadowValues? Preset { get; set; }
  
  
  /// <summary>
  ///   Specifies how far to offset the shadow.
  /// </summary>
  [SchemaAttr("dist")]
  public Int64? Distance { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction to offset the shadow.
  /// </summary>
  [SchemaAttr("dir")]
  public Int32? Direction { get; set; }
  
  
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
  public DocumentModel.Drawings.SchemeColorValues? SchemeColor { get; set; }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}
