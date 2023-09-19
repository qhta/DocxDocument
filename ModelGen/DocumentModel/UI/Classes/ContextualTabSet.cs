namespace DocumentModel.UI;


/// <summary>
///   Defines the ContextualTabSet Class.
/// </summary>
public partial class ContextualTabSet
{
  
  /// <summary>
  ///   idMso
  /// </summary>
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
  
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
  
  public DocumentModel.ElementCollection<DocumentModel.UI.Tab>? Items { get; set; }
  
}
