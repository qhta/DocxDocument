namespace DocumentModel;


/// <summary>
///   Defines the ContextMenu Class.
/// </summary>
public partial class ContextMenu
{
  
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
