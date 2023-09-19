namespace DocumentModel;


/// <summary>
///   Defines the ImageControl Class.
/// </summary>
public partial class ImageControl
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("idQ")]
  public String? QualifiedId { get; set; }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("tag")]
  public String? Tag { get; set; }
  
  
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("enabled")]
  public Boolean? Enabled { get; set; }
  
  
  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getEnabled")]
  public String? GetEnabled { get; set; }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("visible")]
  public Boolean? Visible { get; set; }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getVisible")]
  public String? GetVisible { get; set; }
  
  
  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("image")]
  public String? Image { get; set; }
  
  
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("imageMso")]
  public String? ImageMso { get; set; }
  
  
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getImage")]
  public String? GetImage { get; set; }
  
  
  /// <summary>
  ///   altText, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("altText")]
  public String? AltText { get; set; }
  
  
  /// <summary>
  ///   getAltText, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getAltText")]
  public String? GetAltText { get; set; }
  
}
