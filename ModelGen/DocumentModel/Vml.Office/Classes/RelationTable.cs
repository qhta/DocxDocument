namespace DocumentModel.Vml.Office;


/// <summary>
///   Diagram Relationship Table.
/// </summary>
public partial class RelationTable
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public DM.ElementCollection<Relation>? Items { get; set; }
  
}
