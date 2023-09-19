namespace DocumentModel;


/// <summary>
///   Defines the MenuSeparator Class.
/// </summary>
public partial class MenuSeparator
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
  ///   title, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getTitle")]
  public String? GetTitle { get; set; }
  
}
