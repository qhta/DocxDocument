namespace DocumentModel;


/// <summary>
///   Defines the LayoutContainer Class.
/// </summary>
public partial class LayoutContainer
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
  ///   align, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("align")]
  public DocumentModel.ExpandValues? Align { get; set; }
  
  
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("expand")]
  public DocumentModel.ExpandValues? Expand { get; set; }
  
  
  /// <summary>
  ///   layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("layoutChildren")]
  public DocumentModel.LayoutChildrenValues? LayoutChildren { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
