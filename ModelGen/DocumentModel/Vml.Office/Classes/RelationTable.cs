namespace DocumentModel.Vml.Office;


/// <summary>
///   Diagram Relationship Table.
/// </summary>
public partial class RelationTable
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Vml.Office.Relation>? Items { get; set; }
  
}
