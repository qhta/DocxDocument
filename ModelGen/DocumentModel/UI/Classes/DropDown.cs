namespace DocumentModel.UI;


/// <summary>
///   Defines the DropDown Class.
/// </summary>
public partial class DropDown
{
  
  /// <summary>
  ///   onAction
  /// </summary>
  [SchemaAttr("onAction")]
  public String? OnAction { get; set; }
  
  
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
  ///   image
  /// </summary>
  [SchemaAttr("image")]
  public String? Image { get; set; }
  
  
  /// <summary>
  ///   imageMso
  /// </summary>
  [SchemaAttr("imageMso")]
  public String? ImageMso { get; set; }
  
  
  /// <summary>
  ///   getImage
  /// </summary>
  [SchemaAttr("getImage")]
  public String? GetImage { get; set; }
  
  
  /// <summary>
  ///   showItemImage
  /// </summary>
  [SchemaAttr("showItemImage")]
  public Boolean? ShowItemImage { get; set; }
  
  
  /// <summary>
  ///   getItemCount
  /// </summary>
  [SchemaAttr("getItemCount")]
  public String? GetItemCount { get; set; }
  
  
  /// <summary>
  ///   getItemLabel
  /// </summary>
  [SchemaAttr("getItemLabel")]
  public String? GetItemLabel { get; set; }
  
  
  /// <summary>
  ///   getItemScreentip
  /// </summary>
  [SchemaAttr("getItemScreentip")]
  public String? GetItemScreentip { get; set; }
  
  
  /// <summary>
  ///   getItemSupertip
  /// </summary>
  [SchemaAttr("getItemSupertip")]
  public String? GetItemSupertip { get; set; }
  
  
  /// <summary>
  ///   getItemImage
  /// </summary>
  [SchemaAttr("getItemImage")]
  public String? GetItemImage { get; set; }
  
  
  /// <summary>
  ///   getItemID
  /// </summary>
  [SchemaAttr("getItemID")]
  public String? GetItemID { get; set; }
  
  
  /// <summary>
  ///   sizeString
  /// </summary>
  [SchemaAttr("sizeString")]
  public String? SizeString { get; set; }
  
  
  /// <summary>
  ///   getSelectedItemID
  /// </summary>
  [SchemaAttr("getSelectedItemID")]
  public String? GetSelectedItemID { get; set; }
  
  
  /// <summary>
  ///   getSelectedItemIndex
  /// </summary>
  [SchemaAttr("getSelectedItemIndex")]
  public String? GetSelectedItemIndex { get; set; }
  
  
  /// <summary>
  ///   showItemLabel
  /// </summary>
  [SchemaAttr("showItemLabel")]
  public Boolean? ShowItemLabel { get; set; }
  
  
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
  ///   keytip
  /// </summary>
  [SchemaAttr("keytip")]
  public String? Keytip { get; set; }
  
  
  /// <summary>
  ///   getKeytip
  /// </summary>
  [SchemaAttr("getKeytip")]
  public String? GetKeytip { get; set; }
  
  
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
  
  
  /// <summary>
  ///   showImage
  /// </summary>
  [SchemaAttr("showImage")]
  public Boolean? ShowImage { get; set; }
  
  
  /// <summary>
  ///   getShowImage
  /// </summary>
  [SchemaAttr("getShowImage")]
  public String? GetShowImage { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
