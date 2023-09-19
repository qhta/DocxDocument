namespace DocumentModel;


/// <summary>
///   Defines the ButtonGroup Class.
/// </summary>
public partial class ButtonGroup
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
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
