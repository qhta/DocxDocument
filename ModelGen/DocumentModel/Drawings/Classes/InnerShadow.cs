namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an inner shadow effect. A shadow is applied within the edges of the object according to the parameters given by the attributes.
/// </summary>
public partial class InnerShadow
{
  
  /// <summary>
  ///   Specifies the blur radius.
  /// </summary>
  [SchemaAttr("blurRad")]
  public Int64? BlurRadius { get; set; }
  
  
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
