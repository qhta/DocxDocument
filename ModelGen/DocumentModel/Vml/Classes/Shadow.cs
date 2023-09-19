namespace DocumentModel.Vml;


/// <summary>
///   Defines the Shadow Class.
/// </summary>
public partial class Shadow
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Shadow Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.ShadowValues? Type { get; set; }
  
  
  /// <summary>
  ///   Shadow Transparency
  /// </summary>
  [SchemaAttr("obscured")]
  public Boolean? Obscured { get; set; }
  
  
  /// <summary>
  ///   Shadow Primary Color
  /// </summary>
  [SchemaAttr("color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Shadow Opacity
  /// </summary>
  [SchemaAttr("opacity")]
  public String? Opacity { get; set; }
  
  
  /// <summary>
  ///   Shadow Primary Offset
  /// </summary>
  [SchemaAttr("offset")]
  public String? Offset { get; set; }
  
  
  /// <summary>
  ///   Shadow Secondary Color
  /// </summary>
  [SchemaAttr("color2")]
  public String? Color2 { get; set; }
  
  
  /// <summary>
  ///   Shadow Secondary Offset
  /// </summary>
  [SchemaAttr("offset2")]
  public String? Offset2 { get; set; }
  
  
  /// <summary>
  ///   Shadow Origin
  /// </summary>
  [SchemaAttr("origin")]
  public String? Origin { get; set; }
  
  
  /// <summary>
  ///   Shadow Perspective Matrix
  /// </summary>
  [SchemaAttr("matrix")]
  public String? Matrix { get; set; }
  
}
