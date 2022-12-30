namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public partial class RelationTable
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public Collection<DocumentModel.Vml.Relation>? Relations { get; set; }
  
}
