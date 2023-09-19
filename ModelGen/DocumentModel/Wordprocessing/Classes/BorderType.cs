namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BorderType Class.
/// </summary>
public partial class BorderType
{
  
  /// <summary>
  ///   Border Style
  /// </summary>
  [SchemaAttr("w:val")]
  public DocumentModel.Wordprocessing.BorderValues? Val { get; set; }
  
  
  /// <summary>
  ///   Border Color
  /// </summary>
  [SchemaAttr("w:color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Border Theme Color
  /// </summary>
  [SchemaAttr("w:themeColor")]
  public DocumentModel.Wordprocessing.ThemeColorValues? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   Border Theme Color Tint
  /// </summary>
  [SchemaAttr("w:themeTint")]
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   Border Theme Color Shade
  /// </summary>
  [SchemaAttr("w:themeShade")]
  public String? ThemeShade { get; set; }
  
  
  /// <summary>
  ///   Border Width
  /// </summary>
  [SchemaAttr("w:sz")]
  public UInt32? Size { get; set; }
  
  
  /// <summary>
  ///   Border Spacing Measurement
  /// </summary>
  [SchemaAttr("w:space")]
  public UInt32? Space { get; set; }
  
  
  /// <summary>
  ///   Border Shadow
  /// </summary>
  [SchemaAttr("w:shadow")]
  public Boolean? Shadow { get; set; }
  
  
  /// <summary>
  ///   Create Frame Effect
  /// </summary>
  [SchemaAttr("w:frame")]
  public Boolean? Frame { get; set; }
  
}
