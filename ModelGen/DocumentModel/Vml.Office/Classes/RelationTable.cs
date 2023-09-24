namespace DocumentModel.Vml.Office;


/// <summary>
///   Diagram Relationship Table.
/// </summary>
public partial class RelationTable
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public ElementCollection<Relation>? Items { get; set; }
  
}
