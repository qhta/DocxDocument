namespace DocumentModel;


/// <summary>
///   Defines the BackstageDropDown Class.
/// </summary>
public partial class BackstageDropDown
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
  ///   alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("alignLabel")]
  public DocumentModel.ExpandValues? AlignLabel { get; set; }
  
  
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("expand")]
  public DocumentModel.ExpandValues? Expand { get; set; }
  
  
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
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("onAction")]
  public String? OnAction { get; set; }
  
  
  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("screentip")]
  public String? Screentip { get; set; }
  
  
  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getScreentip")]
  public String? GetScreentip { get; set; }
  
  
  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("supertip")]
  public String? Supertip { get; set; }
  
  
  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getSupertip")]
  public String? GetSupertip { get; set; }
  
  
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
  ///   getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getSelectedItemIndex")]
  public String? GetSelectedItemIndex { get; set; }
  
  
  /// <summary>
  ///   sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("sizeString")]
  public String? SizeString { get; set; }
  
  
  /// <summary>
  ///   getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getItemCount")]
  public String? GetItemCount { get; set; }
  
  
  /// <summary>
  ///   getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getItemLabel")]
  public String? GetItemLabel { get; set; }
  
  
  /// <summary>
  ///   getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getItemID")]
  public String? GetItemID { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.BackstageItemType>? Items { get; set; }
  
}
