namespace DocumentModel.UI;


/// <summary>
///   Defines the Box Class.
/// </summary>
public partial class Box
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
  ///   boxStyle
  /// </summary>
  [SchemaAttr("boxStyle")]
  public DocumentModel.UI.BoxStyleValues? BoxStyle { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
