namespace DocumentModel;


/// <summary>
///   Defines the Item Class.
/// </summary>
public partial class Item
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("label")]
  public String? Label { get; set; }
  
  
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
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("screentip")]
  public String? Screentip { get; set; }
  
  
  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("supertip")]
  public String? Supertip { get; set; }
  
}
