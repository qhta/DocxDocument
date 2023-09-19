namespace DocumentModel;


/// <summary>
///   Defines the TaskGroupTask Class.
/// </summary>
public partial class TaskGroupTask
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
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertAfterMso")]
  public String? InsertAfterMso { get; set; }
  
  
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertBeforeMso")]
  public String? InsertBeforeMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertAfterQ")]
  public String? InsertAfterQulifiedId { get; set; }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertBeforeQ")]
  public String? InsertBeforeQulifiedId { get; set; }
  
  
  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("onAction")]
  public String? OnAction { get; set; }
  
  
  /// <summary>
  ///   isDefinitive, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("isDefinitive")]
  public Boolean? IsDefinitive { get; set; }
  
  
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
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("label")]
  public String? Label { get; set; }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getLabel")]
  public String? GetLabel { get; set; }
  
  
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
  ///   description, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("description")]
  public String? Description { get; set; }
  
  
  /// <summary>
  ///   getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getDescription")]
  public String? GetDescription { get; set; }
  
  
  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("keytip")]
  public String? Keytip { get; set; }
  
  
  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getKeytip")]
  public String? GetKeytip { get; set; }
  
}
