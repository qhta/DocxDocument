namespace DocumentModel.Vml;

/// <summary>
///   Diagram Relationship Table.
/// </summary>
public interface RelationTable: IModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  public Collection<Relation>? Relations { get; set; }
}