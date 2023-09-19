namespace DocumentModel;


/// <summary>
///   Defines the SplitButtonRegular Class.
/// </summary>
public partial class SplitButtonRegular
{
  
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
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("keytip")]
  public String? Keytip { get; set; }
  
  
  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getKeytip")]
  public String? GetKeytip { get; set; }
  
  
  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("showLabel")]
  public Boolean? ShowLabel { get; set; }
  
  
  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getShowLabel")]
  public String? GetShowLabel { get; set; }
  
  public DocumentModel.VisibleButton? VisibleButton { get; set; }
  
  public DocumentModel.VisibleToggleButton? VisibleToggleButton { get; set; }
  
  public DocumentModel.MenuRegular? MenuRegular { get; set; }
  
}
