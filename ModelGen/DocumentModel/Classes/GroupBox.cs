namespace DocumentModel;


/// <summary>
///   Defines the GroupBox Class.
/// </summary>
public partial class GroupBox
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
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("expand")]
  public DocumentModel.ExpandValues? Expand { get; set; }
  
  
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
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
