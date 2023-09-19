namespace DocumentModel.UI;


/// <summary>
///   Defines the TextLabel Class.
/// </summary>
public partial class TextLabel
{
  
  /// <summary>
  ///   id
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   idQ
  /// </summary>
  [SchemaAttr("idQ")]
  public String? IdQ { get; set; }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
  
  /// <summary>
  ///   tag
  /// </summary>
  [SchemaAttr("tag")]
  public String? Tag { get; set; }
  
  
  /// <summary>
  ///   screentip
  /// </summary>
  [SchemaAttr("screentip")]
  public String? Screentip { get; set; }
  
  
  /// <summary>
  ///   getScreentip
  /// </summary>
  [SchemaAttr("getScreentip")]
  public String? GetScreentip { get; set; }
  
  
  /// <summary>
  ///   supertip
  /// </summary>
  [SchemaAttr("supertip")]
  public String? Supertip { get; set; }
  
  
  /// <summary>
  ///   getSupertip
  /// </summary>
  [SchemaAttr("getSupertip")]
  public String? GetSupertip { get; set; }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [SchemaAttr("enabled")]
  public Boolean? Enabled { get; set; }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [SchemaAttr("getEnabled")]
  public String? GetEnabled { get; set; }
  
  
  /// <summary>
  ///   label
  /// </summary>
  [SchemaAttr("label")]
  public String? Label { get; set; }
  
  
  /// <summary>
  ///   getLabel
  /// </summary>
  [SchemaAttr("getLabel")]
  public String? GetLabel { get; set; }
  
  
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  [SchemaAttr("insertAfterMso")]
  public String? InsertAfterMso { get; set; }
  
  
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  [SchemaAttr("insertBeforeMso")]
  public String? InsertBeforeMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  [SchemaAttr("insertAfterQ")]
  public String? InsertAfterQ { get; set; }
  
  
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  [SchemaAttr("insertBeforeQ")]
  public String? InsertBeforeQ { get; set; }
  
  
  /// <summary>
  ///   visible
  /// </summary>
  [SchemaAttr("visible")]
  public Boolean? Visible { get; set; }
  
  
  /// <summary>
  ///   getVisible
  /// </summary>
  [SchemaAttr("getVisible")]
  public String? GetVisible { get; set; }
  
  
  /// <summary>
  ///   showLabel
  /// </summary>
  [SchemaAttr("showLabel")]
  public Boolean? ShowLabel { get; set; }
  
  
  /// <summary>
  ///   getShowLabel
  /// </summary>
  [SchemaAttr("getShowLabel")]
  public String? GetShowLabel { get; set; }
  
}
